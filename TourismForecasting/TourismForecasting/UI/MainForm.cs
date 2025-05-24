using System.Windows.Forms.DataVisualization.Charting;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TourismForecastingApp.Core.Services;
using TourismForecastingApp.Core.Models;
namespace TourismForecasting
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON ����� (*.json)|*.json",
                Title = "�������� ���� � �������������� �������"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // ��������� ������
                    TourismManager.Initialize(openFileDialog.FileName);

                    // ��������� ComboBox ��������
                    var countries = TourismManager.GetAvailableCountries();
                    cbCountrySelector.Items.Clear();
                    cbCountrySelector.Items.AddRange(countries.ToArray());

                    if (countries.Count > 0)
                        cbCountrySelector.SelectedIndex = 0;

                    // ���������� ��� ������ � �������
                    dgvTourismData.DataSource = TourismManager.GetAllRecords();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������ ��� �������� ������: " + ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPlotGraph_Click(object sender, EventArgs e)
        {
            if (cbCountrySelector.SelectedItem == null)
            {
                MessageBox.Show("����������, �������� ������.");
                return;
            }

            string selectedCountry = cbCountrySelector.SelectedItem.ToString();
            var records = TourismManager.GetRecordsByCountry(selectedCountry);

            // ��������� �������
            dgvTourismData.DataSource = records;

            // ������ ������
            chartTourism.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Tourists",
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                BorderWidth = 3
            };

            foreach (var record in records)
            {
                series.Points.AddXY(record.Year, record.Tourists);
            }

            chartTourism.Series.Add(series);
            chartTourism.ChartAreas[0].RecalculateAxesScale();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            var max = TourismManager.GetCountryWithMaxTourists();
            var min = TourismManager.GetCountryWithMinTourists();

            lblMaxCountry.Text = $"��������: {max.Country} � {max.TotalTourists:N0} ���.";
            lblMinCountry.Text = $"�������: {min.Country} � {min.TotalTourists:N0} ���.";
        }

        private void BtnForecast_Click(object sender, EventArgs e)
        {
            if (cbCountrySelector.SelectedItem == null)
            {
                MessageBox.Show("����������, �������� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtYearsToForecast.Text, out int forecastYears) || forecastYears <= 0)
            {
                MessageBox.Show("������� ���������� ���������� ��� ��� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string country = cbCountrySelector.SelectedItem.ToString();

            // �������� �������� ������������ ������ (����� ��������)
            var historicalOriginal = TourismManager.GetRecordsByCountry(country)
                .Select(r => new TourismRecord
                {
                    Country = r.Country,
                    Year = r.Year,
                    Tourists = r.Tourists
                })
                .ToList();

            // �������� ������� �� ������ �����
            var forecast = TourismManager.ForecastByMovingAverage(country, forecastYears);

            // ������� ������
            chartTourism.Series.Clear();

            // ������� � ����� �����
            var seriesHistorical = new System.Windows.Forms.DataVisualization.Charting.Series("�������")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                Color = Color.Blue,
                BorderWidth = 2
            };

            foreach (var record in historicalOriginal)
                seriesHistorical.Points.AddXY(record.Year, record.Tourists);

            // ������� � ������� �����
            var seriesForecast = new System.Windows.Forms.DataVisualization.Charting.Series("�������")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                Color = Color.Red,
                BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash,
                BorderWidth = 2
            };

            foreach (var record in forecast)
                seriesForecast.Points.AddXY(record.Year, record.Tourists);

            // ��������� �����
            chartTourism.Series.Add(seriesHistorical);
            chartTourism.Series.Add(seriesForecast);
        }

    }
}
