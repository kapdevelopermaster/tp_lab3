using System;
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
        private readonly RateModel rateModel;
        private List<RateData> rateData;

        public DataView()
        {
            InitializeComponent();

            rateModel = new RateModel();
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
        private void btnLoadRateFile_Click(object sender, EventArgs e)
        {
            string filePath = GetFilePath();
            if (filePath != null)
            {
                rateData = rateModel.LoadData(filePath);
                DisplayRateData(rateData);
            }
        }

    }
}
