using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public class TrainingModel
{
    public List<TrainingData> LoadData(string filePath)
    {
        var data = new List<TrainingData>();

        using (var reader = new StreamReader(filePath))
        {
            // ���������� ������ ������ (���������)
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                // ������ ������ �� ������
                var trainingData = new TrainingData
                {
                    StartTime = DateTime.ParseExact(values[0], "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture),
                    Duration = TimeSpan.Parse(values[1]),
                    Distance = double.Parse(values[2].Replace(",","."), CultureInfo.InvariantCulture),
                    MaxSpeed = double.Parse(values[3].Replace(",", "."), CultureInfo.InvariantCulture),
                    MinSpeed = double.Parse(values[4].Replace(",", "."), CultureInfo.InvariantCulture),
                    AvgSpeed = double.Parse(values[5].Replace(",", "."), CultureInfo.InvariantCulture),
                    AvgHeartRate = double.Parse(values[6].Replace(",", "."), CultureInfo.InvariantCulture)
                };

                data.Add(trainingData);
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

    public double CalculateTotalWeekendDistance(List<TrainingData> data)
    {
        return data.Where(d => d.StartTime.DayOfWeek == DayOfWeek.Saturday || d.StartTime.DayOfWeek == DayOfWeek.Sunday)
                   .Sum(d => d.Distance);
    }
}