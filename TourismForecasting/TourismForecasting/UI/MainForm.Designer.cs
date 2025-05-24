namespace TourismForecasting
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            txtYearsToForecast = new TextBox();
            BtnForecast = new Button();
            btnAnalyze = new Button();
            btnPlotGraph = new Button();
            chartTourism = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dgvTourismData = new DataGridView();
            cbCountrySelector = new ComboBox();
            btnLoadData = new Button();
            label3 = new Label();
            lblMinCountry = new Label();
            lblMaxCountry = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTourism).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTourismData).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btnAnalyze);
            panel1.Controls.Add(chartTourism);
            panel1.Controls.Add(lblMinCountry);
            panel1.Controls.Add(lblMaxCountry);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1894, 1283);
            panel1.TabIndex = 0;
            // 
            // txtYearsToForecast
            // 
            txtYearsToForecast.Location = new Point(126, 60);
            txtYearsToForecast.Name = "txtYearsToForecast";
            txtYearsToForecast.Size = new Size(200, 39);
            txtYearsToForecast.TabIndex = 11;
            // 
            // BtnForecast
            // 
            BtnForecast.BackColor = Color.LightBlue;
            BtnForecast.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnForecast.Location = new Point(17, 132);
            BtnForecast.Name = "BtnForecast";
            BtnForecast.Size = new Size(431, 46);
            BtnForecast.TabIndex = 9;
            BtnForecast.Text = "Рассчитать";
            BtnForecast.UseVisualStyleBackColor = false;
            BtnForecast.Click += BtnForecast_Click;
            // 
            // btnAnalyze
            // 
            btnAnalyze.BackColor = Color.Azure;
            btnAnalyze.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnalyze.Location = new Point(447, 1158);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(150, 46);
            btnAnalyze.TabIndex = 8;
            btnAnalyze.Text = "Анализ";
            btnAnalyze.UseVisualStyleBackColor = false;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnPlotGraph
            // 
            btnPlotGraph.BackColor = Color.LightBlue;
            btnPlotGraph.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlotGraph.Location = new Point(20, 132);
            btnPlotGraph.Name = "btnPlotGraph";
            btnPlotGraph.Size = new Size(433, 46);
            btnPlotGraph.TabIndex = 7;
            btnPlotGraph.Text = "Загрузка данных по стране";
            btnPlotGraph.UseVisualStyleBackColor = false;
            btnPlotGraph.Click += btnPlotGraph_Click;
            // 
            // chartTourism
            // 
            chartArea1.Name = "ChartArea1";
            chartTourism.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartTourism.Legends.Add(legend1);
            chartTourism.Location = new Point(32, 384);
            chartTourism.Name = "chartTourism";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartTourism.Series.Add(series1);
            chartTourism.Size = new Size(977, 583);
            chartTourism.TabIndex = 6;
            chartTourism.Text = "chart1";
            // 
            // dgvTourismData
            // 
            dgvTourismData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTourismData.Location = new Point(23, 152);
            dgvTourismData.Name = "dgvTourismData";
            dgvTourismData.RowHeadersWidth = 82;
            dgvTourismData.Size = new Size(749, 849);
            dgvTourismData.TabIndex = 5;
            // 
            // cbCountrySelector
            // 
            cbCountrySelector.FormattingEnabled = true;
            cbCountrySelector.Location = new Point(101, 46);
            cbCountrySelector.Name = "cbCountrySelector";
            cbCountrySelector.Size = new Size(242, 40);
            cbCountrySelector.TabIndex = 4;
            // 
            // btnLoadData
            // 
            btnLoadData.BackColor = Color.Azure;
            btnLoadData.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadData.Location = new Point(247, 1024);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(338, 46);
            btnLoadData.TabIndex = 3;
            btnLoadData.Text = "Загрузить данные";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Azure;
            label3.Font = new Font("Sitka Small", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(438, 0);
            label3.Name = "label3";
            label3.Size = new Size(894, 63);
            label3.TabIndex = 2;
            label3.Text = "Анализ динамики туризма в России";
            label3.Click += label3_Click;
            // 
            // lblMinCountry
            // 
            lblMinCountry.AutoSize = true;
            lblMinCountry.BackColor = Color.LightBlue;
            lblMinCountry.Location = new Point(70, 1066);
            lblMinCountry.Name = "lblMinCountry";
            lblMinCountry.Size = new Size(129, 32);
            lblMinCountry.TabIndex = 1;
            lblMinCountry.Text = "Минимум:";
            lblMinCountry.Click += label2_Click;
            // 
            // lblMaxCountry
            // 
            lblMaxCountry.AutoSize = true;
            lblMaxCountry.BackColor = Color.LightBlue;
            lblMaxCountry.Location = new Point(70, 1127);
            lblMaxCountry.Name = "lblMaxCountry";
            lblMaxCountry.Size = new Size(136, 32);
            lblMaxCountry.TabIndex = 0;
            lblMaxCountry.Text = "Максимум:";
            lblMaxCountry.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(32, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(1792, 80);
            panel2.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.Controls.Add(btnPlotGraph);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cbCountrySelector);
            panel3.Location = new Point(18, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(469, 200);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Azure;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(BtnForecast);
            panel4.Controls.Add(txtYearsToForecast);
            panel4.Location = new Point(493, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(466, 200);
            panel4.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SteelBlue;
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(dgvTourismData);
            panel5.Controls.Add(btnLoadData);
            panel5.Location = new Point(1034, 125);
            panel5.Name = "panel5";
            panel5.Size = new Size(790, 1100);
            panel5.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightBlue;
            panel6.Location = new Point(948, 240);
            panel6.Name = "panel6";
            panel6.Size = new Size(400, 200);
            panel6.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Azure;
            panel7.Controls.Add(label4);
            panel7.Location = new Point(23, 20);
            panel7.Name = "panel7";
            panel7.Size = new Size(742, 99);
            panel7.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.SteelBlue;
            panel8.Controls.Add(panel6);
            panel8.Controls.Add(panel3);
            panel8.Controls.Add(panel4);
            panel8.Location = new Point(32, 125);
            panel8.Name = "panel8";
            panel8.Size = new Size(977, 241);
            panel8.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(74, 0);
            label1.Name = "label1";
            label1.Size = new Size(312, 43);
            label1.TabIndex = 0;
            label1.Text = "Данные по стране";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(461, 40);
            label2.TabIndex = 1;
            label2.Text = "Прогноз на следующие годы ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(118, 11);
            label4.Name = "label4";
            label4.Size = new Size(535, 63);
            label4.TabIndex = 0;
            label4.Text = "ИСХОДНЫЕ ДАННЫЕ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightBlue;
            label5.Font = new Font("Sitka Small", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(291, 999);
            label5.Name = "label5";
            label5.Size = new Size(449, 63);
            label5.TabIndex = 15;
            label5.Text = "Статистика стран";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 985);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(977, 240);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1854, 1257);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartTourism).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTourismData).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblMaxCountry;
        private Label label3;
        private Label lblMinCountry;
        private Button btnLoadData;
        private DataGridView dgvTourismData;
        private ComboBox cbCountrySelector;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTourism;
        private Button btnPlotGraph;
        private Button btnAnalyze;
        private Button BtnForecast;
        private TextBox txtYearsToForecast;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel7;
        private Panel panel5;
        private Panel panel8;
        private Panel panel6;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
