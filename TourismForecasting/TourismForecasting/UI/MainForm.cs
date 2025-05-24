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
                Filter = "JSON файлы (*.json)|*.json",
                Title = "Выберите файл с туристическими данными"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Загружаем данные
                    TourismManager.Initialize(openFileDialog.FileName);

                    // Обновляем ComboBox странами
                    var countries = TourismManager.GetAvailableCountries();
                    cbCountrySelector.Items.Clear();
                    cbCountrySelector.Items.AddRange(countries.ToArray());

                    if (countries.Count > 0)
                        cbCountrySelector.SelectedIndex = 0;

                    // Показываем все данные в таблице
                    dgvTourismData.DataSource = TourismManager.GetAllRecords();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPlotGraph_Click(object sender, EventArgs e)
        {
            if (cbCountrySelector.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите страну.");
                return;
            }

            string selectedCountry = cbCountrySelector.SelectedItem.ToString();
            var records = TourismManager.GetRecordsByCountry(selectedCountry);

            // Обновляем таблицу
            dgvTourismData.DataSource = records;

            // Строим график
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

            lblMaxCountry.Text = $"Максимум: {max.Country} — {max.TotalTourists:N0} чел.";
            lblMinCountry.Text = $"Минимум: {min.Country} — {min.TotalTourists:N0} чел.";
        }

        private void BtnForecast_Click(object sender, EventArgs e)
        {
            if (cbCountrySelector.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите страну.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtYearsToForecast.Text, out int forecastYears) || forecastYears <= 0)
            {
                MessageBox.Show("Введите корректное количество лет для прогноза.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string country = cbCountrySelector.SelectedItem.ToString();

            // Получаем ИСХОДНЫЕ исторические данные (чисто реальные)
            var historicalOriginal = TourismManager.GetRecordsByCountry(country)
                .Select(r => new TourismRecord
                {
                    Country = r.Country,
                    Year = r.Year,
                    Tourists = r.Tourists
                })
                .ToList();

            // Получаем прогноз на основе КОПИИ
            var forecast = TourismManager.ForecastByMovingAverage(country, forecastYears);

            // Очищаем график
            chartTourism.Series.Clear();

            // История — синяя линия
            var seriesHistorical = new System.Windows.Forms.DataVisualization.Charting.Series("История")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                Color = Color.Blue,
                BorderWidth = 2
            };

            foreach (var record in historicalOriginal)
                seriesHistorical.Points.AddXY(record.Year, record.Tourists);

            // Прогноз — красная линия
            var seriesForecast = new System.Windows.Forms.DataVisualization.Charting.Series("Прогноз")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                Color = Color.Red,
                BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash,
                BorderWidth = 2
            };

            foreach (var record in forecast)
                seriesForecast.Points.AddXY(record.Year, record.Tourists);

            // Добавляем серии
            chartTourism.Series.Add(seriesHistorical);
            chartTourism.Series.Add(seriesForecast);
        }

    }
}
