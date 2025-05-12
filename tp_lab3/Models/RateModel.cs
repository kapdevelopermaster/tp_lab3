using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;

public class RateModel
{
    public List<RateData> LoadData(string filePath)
    {
        var data = new List<RateData>();

        using (var reader = new StreamReader(filePath))
        {
            // ѕропускаем первую строку (заголовок)
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                // ѕарсим данные из строки
                var rateData = new RateData
                {
                    DateRate = DateTime.ParseExact(values[0], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    RateUSD = double.Parse(values[1].Replace(",","."), CultureInfo.InvariantCulture),
                    RateEuro = double.Parse(values[2].Replace(",", "."), CultureInfo.InvariantCulture)
                };

                data.Add(rateData);
            }
        }

        return data;
    }

    public List<double> ExtrapolateData(List<double> data, int days)
    {
        var extrapolatedData = new List<double>(data);
        for (int i = 0; i < days; i++)
        {
            double sum = 0;
            int count = 0;
            for (int j = Math.Max(0, extrapolatedData.Count - days); j < extrapolatedData.Count; j++)
            {
                sum += extrapolatedData[j];
                count++;
            }
            extrapolatedData.Add(sum / count);
        }
        return extrapolatedData;
    }

    public object CalculateGain(List<RateData> data)
    {
        // —ортируем данные по дате (если они не отсортированы)
        var sortedData = data.OrderBy(d => d.DateRate).ToList();

        // —писок дл€ хранени€ ежедневных изменений курса
        var dailyChanges = new List<(DateTime Date, double ChangeUSD, double ChangeEuro)>();

        // ¬ычисл€ем изменени€ между соседними дн€ми
        for (int i = 1; i < sortedData.Count; i++)
        {
            var previousDay = sortedData[i - 1];
            var currentDay = sortedData[i];
            double changeUSD = currentDay.RateUSD - previousDay.RateUSD;
            double changeEuro = currentDay.RateEuro - previousDay.RateEuro;
            dailyChanges.Add((currentDay.DateRate, changeUSD, changeEuro));
        }

        // Ќаходим максимальный рост и падение рубл€ по отношению USD
        var maxGainUSD = dailyChanges.OrderByDescending(x => x.ChangeUSD).First();
        var maxLossUSD = dailyChanges.OrderBy(x => x.ChangeUSD).First();

        // Ќаходим максимальный рост и падение рубл€ по отношению Euro
        var maxGainEuro = dailyChanges.OrderByDescending(x => x.ChangeEuro).First();
        var maxLossEuro = dailyChanges.OrderBy(x => x.ChangeEuro).First();

        return new {
            maxGainUSD = new { Date = maxGainUSD.Date, ChangeUSD = maxGainUSD.ChangeUSD },
            maxLossUSD = new { Date = maxLossUSD.Date, ChangeUSD = maxLossUSD.ChangeUSD },
            maxGainEuro = new { Date = maxGainEuro.Date, ChangeEuro = maxGainEuro.ChangeEuro },
            maxLossEuro = new { Date = maxLossEuro.Date, ChangeEuro = maxLossEuro.ChangeEuro }
        };
    }
}