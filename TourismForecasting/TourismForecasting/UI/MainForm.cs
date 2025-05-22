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
            var allRecords = TourismManager.GetAllRecords();

            var countrySums = allRecords
                .GroupBy(r => r.Country)
                .Select(g => new
                {
                    Country = g.Key,
                    TotalTourists = g.Sum(r => r.Tourists)
                })
                .ToList();

            var maxCountry = countrySums.OrderByDescending(c => c.TotalTourists).First();
            var minCountry = countrySums.OrderBy(c => c.TotalTourists).First();

            lblMaxCountry.Text = $"����: {maxCountry.Country} ({maxCountry.TotalTourists:N0})";
            lblMinCountry.Text = $"���: {minCountry.Country} ({minCountry.TotalTourists:N0})";
        }
    }
}
