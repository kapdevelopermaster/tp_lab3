namespace tp_lab3.Views
{
    partial class DataView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartTraining = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotalDistance = new System.Windows.Forms.Label();
            this.nudExtrapolationTrainingDays = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowTrainingChart = new System.Windows.Forms.Button();
            this.dataTrainingGridView = new System.Windows.Forms.DataGridView();
            this.btnLoadTrainingFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataRateGridView = new System.Windows.Forms.DataGridView();
            this.btnLoadRateFile = new System.Windows.Forms.Button();
            this.lblInfoRate = new System.Windows.Forms.Label();
            this.nudExtrapolationRateDays = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chartRate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnShowRateChart = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTraining)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtrapolationTrainingDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrainingGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRateGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtrapolationRateDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRate)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(881, 686);
            this.tabControl.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartTraining);
            this.tabPage1.Controls.Add(this.lblTotalDistance);
            this.tabPage1.Controls.Add(this.nudExtrapolationTrainingDays);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnShowTrainingChart);
            this.tabPage1.Controls.Add(this.dataTrainingGridView);
            this.tabPage1.Controls.Add(this.btnLoadTrainingFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(873, 660);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Данные тренировок";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartTraining
            // 
            this.chartTraining.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartTraining.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTraining.Legends.Add(legend1);
            this.chartTraining.Location = new System.Drawing.Point(8, 296);
            this.chartTraining.Name = "chartTraining";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTraining.Series.Add(series1);
            this.chartTraining.Size = new System.Drawing.Size(859, 361);
            this.chartTraining.TabIndex = 11;
            this.chartTraining.Text = "chart1";
            // 
            // lblTotalDistance
            // 
            this.lblTotalDistance.AutoSize = true;
            this.lblTotalDistance.Location = new System.Drawing.Point(489, 272);
            this.lblTotalDistance.Name = "lblTotalDistance";
            this.lblTotalDistance.Size = new System.Drawing.Size(122, 13);
            this.lblTotalDistance.TabIndex = 8;
            this.lblTotalDistance.Text = "Distance on Weekends:";
            // 
            // nudExtrapolationTrainingDays
            // 
            this.nudExtrapolationTrainingDays.Location = new System.Drawing.Point(359, 270);
            this.nudExtrapolationTrainingDays.Name = "nudExtrapolationTrainingDays";
            this.nudExtrapolationTrainingDays.Size = new System.Drawing.Size(55, 20);
            this.nudExtrapolationTrainingDays.TabIndex = 9;
            this.nudExtrapolationTrainingDays.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "NumberExtrapolationDay:";
            // 
            // btnShowTrainingChart
            // 
            this.btnShowTrainingChart.Location = new System.Drawing.Point(8, 267);
            this.btnShowTrainingChart.Name = "btnShowTrainingChart";
            this.btnShowTrainingChart.Size = new System.Drawing.Size(169, 23);
            this.btnShowTrainingChart.TabIndex = 7;
            this.btnShowTrainingChart.Text = "Показать графики";
            this.btnShowTrainingChart.UseVisualStyleBackColor = true;
            this.btnShowTrainingChart.Click += new System.EventHandler(this.btnShowTrainingChart_Click);
            // 
            // dataTrainingGridView
            // 
            this.dataTrainingGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTrainingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTrainingGridView.Location = new System.Drawing.Point(8, 35);
            this.dataTrainingGridView.Name = "dataTrainingGridView";
            this.dataTrainingGridView.Size = new System.Drawing.Size(829, 216);
            this.dataTrainingGridView.TabIndex = 6;
            // 
            // btnLoadTrainingFile
            // 
            this.btnLoadTrainingFile.Location = new System.Drawing.Point(8, 6);
            this.btnLoadTrainingFile.Name = "btnLoadTrainingFile";
            this.btnLoadTrainingFile.Size = new System.Drawing.Size(172, 23);
            this.btnLoadTrainingFile.TabIndex = 5;
            this.btnLoadTrainingFile.Text = "Загрузить файл тренировок";
            this.btnLoadTrainingFile.UseVisualStyleBackColor = true;
            this.btnLoadTrainingFile.Click += new System.EventHandler(this.btnLoadTrainingFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblInfoRate);
            this.tabPage2.Controls.Add(this.nudExtrapolationRateDays);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.chartRate);
            this.tabPage2.Controls.Add(this.btnShowRateChart);
            this.tabPage2.Controls.Add(this.dataRateGridView);
            this.tabPage2.Controls.Add(this.btnLoadRateFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(873, 660);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Данные курса валют";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataRateGridView
            // 
            this.dataRateGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRateGridView.Location = new System.Drawing.Point(9, 35);
            this.dataRateGridView.Name = "dataRateGridView";
            this.dataRateGridView.Size = new System.Drawing.Size(861, 200);
            this.dataRateGridView.TabIndex = 7;
            // 
            // btnLoadRateFile
            // 
            this.btnLoadRateFile.Location = new System.Drawing.Point(8, 6);
            this.btnLoadRateFile.Name = "btnLoadRateFile";
            this.btnLoadRateFile.Size = new System.Drawing.Size(172, 23);
            this.btnLoadRateFile.TabIndex = 6;
            this.btnLoadRateFile.Text = "Загрузить файл курса валют";
            this.btnLoadRateFile.UseVisualStyleBackColor = true;
            this.btnLoadRateFile.Click += new System.EventHandler(this.btnLoadRateFile_Click);
            // 
            // lblInfoRate
            // 
            this.lblInfoRate.AutoSize = true;
            this.lblInfoRate.Location = new System.Drawing.Point(446, 240);
            this.lblInfoRate.Name = "lblInfoRate";
            this.lblInfoRate.Size = new System.Drawing.Size(125, 13);
            this.lblInfoRate.TabIndex = 16;
            this.lblInfoRate.Text = "Информация о валюте:";
            // 
            // nudExtrapolationRateDays
            // 
            this.nudExtrapolationRateDays.Location = new System.Drawing.Point(341, 246);
            this.nudExtrapolationRateDays.Name = "nudExtrapolationRateDays";
            this.nudExtrapolationRateDays.Size = new System.Drawing.Size(55, 20);
            this.nudExtrapolationRateDays.TabIndex = 15;
            this.nudExtrapolationRateDays.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "NumberExtrapolationDay:";
            // 
            // chartRate
            // 
            this.chartRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartRate.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRate.Legends.Add(legend2);
            this.chartRate.Location = new System.Drawing.Point(9, 318);
            this.chartRate.Name = "chartRate";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartRate.Series.Add(series2);
            this.chartRate.Size = new System.Drawing.Size(859, 336);
            this.chartRate.TabIndex = 13;
            this.chartRate.Text = "chart1";
            // 
            // btnShowRateChart
            // 
            this.btnShowRateChart.Location = new System.Drawing.Point(9, 243);
            this.btnShowRateChart.Name = "btnShowRateChart";
            this.btnShowRateChart.Size = new System.Drawing.Size(169, 23);
            this.btnShowRateChart.TabIndex = 12;
            this.btnShowRateChart.Text = "Показать графики";
            this.btnShowRateChart.UseVisualStyleBackColor = true;
            this.btnShowRateChart.Click += new System.EventHandler(this.btnShowRateChart_Click);
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 686);
            this.Controls.Add(this.tabControl);
            this.Name = "DataView";
            this.Text = "DataView";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTraining)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtrapolationTrainingDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTrainingGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRateGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtrapolationRateDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataTrainingGridView;
        private System.Windows.Forms.Button btnLoadTrainingFile;
        private System.Windows.Forms.DataGridView dataRateGridView;
        private System.Windows.Forms.Button btnLoadRateFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTraining;
        private System.Windows.Forms.Label lblTotalDistance;
        private System.Windows.Forms.NumericUpDown nudExtrapolationTrainingDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowTrainingChart;
        private System.Windows.Forms.Label lblInfoRate;
        private System.Windows.Forms.NumericUpDown nudExtrapolationRateDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRate;
        private System.Windows.Forms.Button btnShowRateChart;
    }
}