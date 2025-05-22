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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTourism).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTourismData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Olive;
            panel1.Controls.Add(txtYearsToForecast);
            panel1.Controls.Add(BtnForecast);
            panel1.Controls.Add(btnAnalyze);
            panel1.Controls.Add(btnPlotGraph);
            panel1.Controls.Add(chartTourism);
            panel1.Controls.Add(dgvTourismData);
            panel1.Controls.Add(cbCountrySelector);
            panel1.Controls.Add(btnLoadData);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblMinCountry);
            panel1.Controls.Add(lblMaxCountry);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1829, 1153);
            panel1.TabIndex = 0;
            // 
            // txtYearsToForecast
            // 
            txtYearsToForecast.Location = new Point(1007, 965);
            txtYearsToForecast.Name = "txtYearsToForecast";
            txtYearsToForecast.Size = new Size(200, 39);
            txtYearsToForecast.TabIndex = 11;
            // 
            // BtnForecast
            // 
            BtnForecast.Location = new Point(1288, 878);
            BtnForecast.Name = "BtnForecast";
            BtnForecast.Size = new Size(150, 46);
            BtnForecast.TabIndex = 9;
            BtnForecast.Text = "button1";
            BtnForecast.UseVisualStyleBackColor = true;
            BtnForecast.Click += BtnForecast_Click;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(93, 864);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(150, 46);
            btnAnalyze.TabIndex = 8;
            btnAnalyze.Text = "Анализ";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnPlotGraph
            // 
            btnPlotGraph.Location = new Point(636, 111);
            btnPlotGraph.Name = "btnPlotGraph";
            btnPlotGraph.Size = new Size(433, 46);
            btnPlotGraph.TabIndex = 7;
            btnPlotGraph.Text = "Загрузка данных по стране";
            btnPlotGraph.UseVisualStyleBackColor = true;
            btnPlotGraph.Click += btnPlotGraph_Click;
            // 
            // chartTourism
            // 
            chartArea3.Name = "ChartArea1";
            chartTourism.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartTourism.Legends.Add(legend3);
            chartTourism.Location = new Point(916, 188);
            chartTourism.Name = "chartTourism";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartTourism.Series.Add(series3);
            chartTourism.Size = new Size(875, 657);
            chartTourism.TabIndex = 6;
            chartTourism.Text = "chart1";
            // 
            // dgvTourismData
            // 
            dgvTourismData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTourismData.Location = new Point(51, 188);
            dgvTourismData.Name = "dgvTourismData";
            dgvTourismData.RowHeadersWidth = 82;
            dgvTourismData.Size = new Size(757, 521);
            dgvTourismData.TabIndex = 5;
            // 
            // cbCountrySelector
            // 
            cbCountrySelector.FormattingEnabled = true;
            cbCountrySelector.Location = new Point(713, 65);
            cbCountrySelector.Name = "cbCountrySelector";
            cbCountrySelector.Size = new Size(242, 40);
            cbCountrySelector.TabIndex = 4;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(161, 730);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(338, 46);
            btnLoadData.TabIndex = 3;
            btnLoadData.Text = "Загрузить данные";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(709, 9);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 2;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // lblMinCountry
            // 
            lblMinCountry.AutoSize = true;
            lblMinCountry.Location = new Point(279, 878);
            lblMinCountry.Name = "lblMinCountry";
            lblMinCountry.Size = new Size(55, 32);
            lblMinCountry.TabIndex = 1;
            lblMinCountry.Text = "min";
            lblMinCountry.Click += label2_Click;
            // 
            // lblMaxCountry
            // 
            lblMaxCountry.AutoSize = true;
            lblMaxCountry.Location = new Point(279, 834);
            lblMaxCountry.Name = "lblMaxCountry";
            lblMaxCountry.Size = new Size(58, 32);
            lblMaxCountry.TabIndex = 0;
            lblMaxCountry.Text = "max";
            lblMaxCountry.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1803, 1076);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartTourism).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTourismData).EndInit();
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
    }
}
