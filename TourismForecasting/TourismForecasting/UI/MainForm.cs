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
    }
}
