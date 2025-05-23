﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace tp_lab3.Views
{
    public partial class DataView : Form
    {
        private readonly TrainingModel trainingModel;
        private List<TrainingData> trainingData;
        
        private readonly RateModel rateModel;
        private List<RateData> rateData;

        public DataView()
        {
            InitializeComponent();

            trainingModel = new TrainingModel();
            rateModel = new RateModel();

            if (tabControl.SelectedTab.Text == "Данные тренировок")
            {
                DisplayTrainingChart(new List<double>(), new List<double>(), new List<double>(), new List<double>());
            }
            else if (tabControl.SelectedTab.Text == "Данные курса валют")
            {
                DisplayRateChart(new List<double>(), new List<double>(), new List<double>(), new List<double>());
            }
        }
        
        public void DisplayTrainingData(List<TrainingData> data)
        {
            dataTrainingGridView.DataSource = data;
        }
        
        public void DisplayRateData(List<RateData> data)
        {
            dataRateGridView.DataSource = data;
        }

        public string GetFilePath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
            }
            return null;
        }

        // Обработчики событий кнопок
        private void btnLoadTrainingFile_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePath();
            if (filePath != null)
            {
                trainingData = trainingModel.LoadData(filePath);
                DisplayTrainingData(trainingData);
            }
        }

        private void btnLoadRateFile_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePath();
            if (filePath != null)
            {
                rateData = rateModel.LoadData(filePath);
                DisplayRateData(rateData);
            }
        }

        public void DisplayTrainingChart(List<double> parameter1, List<double> parameter2, List<double> extrapolatedData1, List<double> extrapolatedData2)
        {
            // Очистка предыдущих данных
            chartTraining.Series.Clear();

            // Настройка осей
            chartTraining.ChartAreas[0].AxisX.Title = "Days"; // Название оси X
            chartTraining.ChartAreas[0].AxisY.Title = "Values"; // Название оси Y
            chartTraining.ChartAreas[0].AxisX.Interval = 1; // Интервал между значениями на оси X

            chartTraining.ChartAreas[0].CursorX.Interval = 0.1;
            chartTraining.ChartAreas[0].CursorX.AutoScroll = true;
            chartTraining.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartTraining.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

            chartTraining.ChartAreas[0].CursorY.Interval = 0.1;
            chartTraining.ChartAreas[0].CursorY.AutoScroll = true;
            chartTraining.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chartTraining.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            Series series;

            // Добавление серии для экстраполированных данных параметра 1
            series = chartTraining.Series.Add("ExtrapolatedAvgSpeed");
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.LightBlue;
            series.BorderWidth = 2;
            series.MarkerStyle = MarkerStyle.Diamond;
            series.MarkerSize = 8;
            series.Points.DataBindY(extrapolatedData1);

            // Добавление серии для экстраполированных данных параметра 2
            series = chartTraining.Series.Add("ExtrapolatedAvgHeartRate");
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.Orange;
            series.BorderWidth = 2;
            series.MarkerStyle = MarkerStyle.Diamond;
            series.MarkerSize = 8;
            series.Points.DataBindY(extrapolatedData2);

            // Добавление серии для первого параметра (например, AvgSpeed)
            series = chartTraining.Series.Add("AvgSpeed");
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.Blue;
            series.BorderWidth = 2;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.Points.DataBindY(parameter1);

            // Добавление серии для второго параметра (например, AvgHeartRate)
            series = chartTraining.Series.Add("AvgHeartRate");
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.Red;
            series.BorderWidth = 2;
            series.MarkerStyle = MarkerStyle.Square;
            series.MarkerSize = 8;
            series.Points.DataBindY(parameter2);
        }

        public void DisplayRateChart(List<double> parameter1, List<double> parameter2, List<double> extrapolatedData1, List<double> extrapolatedData2)
        {
            // Очистка предыдущих данных
            chartRate.Series.Clear();

            // Настройка осей
            chartRate.ChartAreas[0].AxisX.Title = "Days"; // Название оси X
            chartRate.ChartAreas[0].AxisY.Title = "Values"; // Название оси Y
            chartRate.ChartAreas[0].AxisX.Interval = 1; // Интервал между значениями на оси X

            chartRate.ChartAreas[0].CursorX.Interval = 0.1;
            chartRate.ChartAreas[0].CursorX.AutoScroll = true;
            chartRate.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chartRate.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

            chartRate.ChartAreas[0].CursorY.Interval = 0.1;
            chartRate.ChartAreas[0].CursorY.AutoScroll = true;
            chartRate.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chartRate.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            Series series;

            // Добавление серии для экстраполированных данных параметра 1
            series = chartRate.Series.Add("ExtrapolatedUSD");
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.LightBlue;
            series.BorderWidth = 2;
            series.MarkerStyle = MarkerStyle.Diamond;
            series.MarkerSize = 8;
            series.Points.DataBindY(extrapolatedData1);

            // Добавление серии для экстраполированных данных параметра 2
            series = chartRate.Series.Add("ExtrapolatedEURO");
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.Orange;
            series.BorderWidth = 2;
            series.MarkerStyle = MarkerStyle.Diamond;
            series.MarkerSize = 8;
            series.Points.DataBindY(extrapolatedData2);

            // Добавление серии для первого параметра
            series = chartRate.Series.Add("USD");
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.Blue;
            series.BorderWidth = 2;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;
            series.Points.DataBindY(parameter1);

            // Добавление серии для второго параметра
            series = chartRate.Series.Add("EURO");
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.Red;
            series.BorderWidth = 2;
            series.MarkerStyle = MarkerStyle.Square;
            series.MarkerSize = 8;
            series.Points.DataBindY(parameter2);
        }

        public void DisplayTrainingTotalDistance(double totalDistance)
        {
            lblTotalDistance.Text = $"Total Distance on Weekends: {totalDistance} km";
        }

        public int GetExtrapolationTrainingDays()
        {
            return (int)nudExtrapolationTrainingDays.Value;
        }

        public int GetExtrapolationRateDays()
        {
            return (int)nudExtrapolationRateDays.Value;
        }

        private void btnShowTrainingChart_Click(object sender, EventArgs e)
        {
            if (trainingData == null || trainingData.Count == 0) return;

            var parameter1 = trainingData.Select(d => d.AvgSpeed).ToList();
            var parameter2 = trainingData.Select(d => d.AvgHeartRate).ToList();
            int days = GetExtrapolationTrainingDays();
            var extrapolatedData1 = trainingModel.ExtrapolateData(parameter1, days);
            var extrapolatedData2 = trainingModel.ExtrapolateData(parameter2, days);

            DisplayTrainingChart(parameter1, parameter2, extrapolatedData1, extrapolatedData2);

            double totalDistance = trainingModel.CalculateTotalWeekendDistance(trainingData);
            DisplayTrainingTotalDistance(totalDistance);
        }

        private void btnShowRateChart_Click(object sender, EventArgs e)
        {
            if (rateData == null || rateData.Count == 0) return;

            var parameter1 = rateData.Select(d => d.RateUSD).ToList();
            var parameter2 = rateData.Select(d => d.RateEuro).ToList();
            int days = GetExtrapolationRateDays();
            var extrapolatedData1 = rateModel.ExtrapolateData(parameter1, days);
            var extrapolatedData2 = rateModel.ExtrapolateData(parameter2, days);

            DisplayRateChart(parameter1, parameter2, extrapolatedData1, extrapolatedData2);

            dynamic gain = rateModel.CalculateGain(rateData);

            lblInfoRate.Text =
                $"Информация о валюте:\n" +
                $"USD: макс.рост: {gain.maxGainUSD.ChangeUSD:F2} в день {gain.maxGainUSD.Date:dd.MM.yyyy}\n" +
                $"USD: макс.пониж.: {-gain.maxLossUSD.ChangeUSD:F2} в день {gain.maxLossUSD.Date:dd.MM.yyyy}\n" +
                $"EUR: макс.рост: {gain.maxGainEuro.ChangeEuro:F2} в день {gain.maxGainEuro.Date:dd.MM.yyyy}\n" +
                $"EUR: макс.пониж: {-gain.maxLossEuro.ChangeEuro:F2} в день {gain.maxLossEuro.Date:dd.MM.yyyy}\n";
        }

    }
}
