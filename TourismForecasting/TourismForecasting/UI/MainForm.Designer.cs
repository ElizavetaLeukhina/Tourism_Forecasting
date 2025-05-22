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
            panel1 = new Panel();
            dgvTourismData = new DataGridView();
            cbCountrySelector = new ComboBox();
            btnLoadData = new Button();
            label3 = new Label();
            lblMinCountry = new Label();
            lblMaxCountry = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTourismData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Olive;
            panel1.Controls.Add(chart1);
            panel1.Controls.Add(dgvTourismData);
            panel1.Controls.Add(cbCountrySelector);
            panel1.Controls.Add(btnLoadData);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblMinCountry);
            panel1.Controls.Add(lblMaxCountry);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1829, 897);
            panel1.TabIndex = 0;
            // 
            // dgvTourismData
            // 
            dgvTourismData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTourismData.Location = new Point(1257, 147);
            dgvTourismData.Name = "dgvTourismData";
            dgvTourismData.RowHeadersWidth = 82;
            dgvTourismData.Size = new Size(480, 300);
            dgvTourismData.TabIndex = 5;
            // 
            // cbCountrySelector
            // 
            cbCountrySelector.FormattingEnabled = true;
            cbCountrySelector.Location = new Point(522, 99);
            cbCountrySelector.Name = "cbCountrySelector";
            cbCountrySelector.Size = new Size(242, 40);
            cbCountrySelector.TabIndex = 4;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(743, 442);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(338, 46);
            btnLoadData.TabIndex = 3;
            btnLoadData.Text = "Загрузить данные";
            btnLoadData.UseVisualStyleBackColor = true;
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
            lblMinCountry.Location = new Point(1243, 523);
            lblMinCountry.Name = "lblMinCountry";
            lblMinCountry.Size = new Size(55, 32);
            lblMinCountry.TabIndex = 1;
            lblMinCountry.Text = "min";
            lblMinCountry.Click += label2_Click;
            // 
            // lblMaxCountry
            // 
            lblMaxCountry.AutoSize = true;
            lblMaxCountry.Location = new Point(852, 500);
            lblMaxCountry.Name = "lblMaxCountry";
            lblMaxCountry.Size = new Size(58, 32);
            lblMaxCountry.TabIndex = 0;
            lblMaxCountry.Text = "max";
            lblMaxCountry.Click += label1_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(64, 225);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(600, 600);
            chart1.TabIndex = 6;
            chart1.Text = "chart1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1803, 879);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTourismData).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
