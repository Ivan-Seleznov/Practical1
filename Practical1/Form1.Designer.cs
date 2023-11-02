namespace Practical1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultsTextLable = new System.Windows.Forms.Label();
            this.XnTextLable = new System.Windows.Forms.Label();
            this.XkTextLable = new System.Windows.Forms.Label();
            this.hTextLable = new System.Windows.Forms.Label();
            this.aTextLable = new System.Windows.Forms.Label();
            this.XnTextBox = new System.Windows.Forms.TextBox();
            this.XkTextBox = new System.Windows.Forms.TextBox();
            this.hTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.роботаЗМасивамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OneDimensionalArrayButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TwoDimensionalArrayButton = new System.Windows.Forms.ToolStripMenuItem();
            this.unitTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(445, 139);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(434, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dataGridView1.Location = new System.Drawing.Point(12, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(421, 300);
            this.dataGridView1.TabIndex = 1;
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.MinimumWidth = 6;
            this.x.Name = "x";
            this.x.Width = 125;
            // 
            // y
            // 
            this.y.HeaderText = "y";
            this.y.MinimumWidth = 6;
            this.y.Name = "y";
            this.y.Width = 125;
            // 
            // ResultsTextLable
            // 
            this.ResultsTextLable.AutoSize = true;
            this.ResultsTextLable.Location = new System.Drawing.Point(317, 106);
            this.ResultsTextLable.Name = "ResultsTextLable";
            this.ResultsTextLable.Size = new System.Drawing.Size(88, 16);
            this.ResultsTextLable.TabIndex = 2;
            this.ResultsTextLable.Text = "Результати:";
            // 
            // XnTextLable
            // 
            this.XnTextLable.AutoSize = true;
            this.XnTextLable.Location = new System.Drawing.Point(21, 40);
            this.XnTextLable.Name = "XnTextLable";
            this.XnTextLable.Size = new System.Drawing.Size(22, 16);
            this.XnTextLable.TabIndex = 3;
            this.XnTextLable.Text = "Xn";
            // 
            // XkTextLable
            // 
            this.XkTextLable.AutoSize = true;
            this.XkTextLable.Location = new System.Drawing.Point(131, 40);
            this.XkTextLable.Name = "XkTextLable";
            this.XkTextLable.Size = new System.Drawing.Size(22, 16);
            this.XkTextLable.TabIndex = 4;
            this.XkTextLable.Text = "Xk";
            // 
            // hTextLable
            // 
            this.hTextLable.AutoSize = true;
            this.hTextLable.Location = new System.Drawing.Point(240, 40);
            this.hTextLable.Name = "hTextLable";
            this.hTextLable.Size = new System.Drawing.Size(14, 16);
            this.hTextLable.TabIndex = 5;
            this.hTextLable.Text = "h";
            // 
            // aTextLable
            // 
            this.aTextLable.Location = new System.Drawing.Point(358, 40);
            this.aTextLable.Name = "aTextLable";
            this.aTextLable.Size = new System.Drawing.Size(14, 16);
            this.aTextLable.TabIndex = 6;
            this.aTextLable.Text = "a";
            // 
            // XnTextBox
            // 
            this.XnTextBox.Location = new System.Drawing.Point(24, 67);
            this.XnTextBox.Name = "XnTextBox";
            this.XnTextBox.Size = new System.Drawing.Size(72, 22);
            this.XnTextBox.TabIndex = 7;
            this.XnTextBox.Text = "-1,78";
            // 
            // XkTextBox
            // 
            this.XkTextBox.Location = new System.Drawing.Point(134, 67);
            this.XkTextBox.Name = "XkTextBox";
            this.XkTextBox.Size = new System.Drawing.Size(72, 22);
            this.XkTextBox.TabIndex = 8;
            this.XkTextBox.Text = "11,99";
            // 
            // hTextBox
            // 
            this.hTextBox.Location = new System.Drawing.Point(243, 67);
            this.hTextBox.Name = "hTextBox";
            this.hTextBox.Size = new System.Drawing.Size(72, 22);
            this.hTextBox.TabIndex = 9;
            this.hTextBox.Text = "0,5";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(361, 69);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(72, 22);
            this.aTextBox.TabIndex = 10;
            this.aTextBox.Text = "0,1";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(747, 69);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(132, 23);
            this.CalculateButton.TabIndex = 11;
            this.CalculateButton.Text = "Обрахувати";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.роботаЗМасивамиToolStripMenuItem,
            this.unitTestsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // роботаЗМасивамиToolStripMenuItem
            // 
            this.роботаЗМасивамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OneDimensionalArrayButton,
            this.TwoDimensionalArrayButton});
            this.роботаЗМасивамиToolStripMenuItem.Name = "роботаЗМасивамиToolStripMenuItem";
            this.роботаЗМасивамиToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.роботаЗМасивамиToolStripMenuItem.Text = "Робота з масивами";
            // 
            // OneDimensionalArrayButton
            // 
            this.OneDimensionalArrayButton.Name = "OneDimensionalArrayButton";
            this.OneDimensionalArrayButton.Size = new System.Drawing.Size(181, 26);
            this.OneDimensionalArrayButton.Text = "одновимірні";
            this.OneDimensionalArrayButton.Click += new System.EventHandler(this.OneDimensionalArrayButton_Click);
            // 
            // TwoDimensionalArrayButton
            // 
            this.TwoDimensionalArrayButton.Name = "TwoDimensionalArrayButton";
            this.TwoDimensionalArrayButton.Size = new System.Drawing.Size(181, 26);
            this.TwoDimensionalArrayButton.Text = "двовимірні";
            this.TwoDimensionalArrayButton.Click += new System.EventHandler(this.TwoDimensionalArrayButton_Click);
            // 
            // unitTestsToolStripMenuItem
            // 
            this.unitTestsToolStripMenuItem.Name = "unitTestsToolStripMenuItem";
            this.unitTestsToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.unitTestsToolStripMenuItem.Text = "UnitTests";
            this.unitTestsToolStripMenuItem.Click += new System.EventHandler(this.unitTestsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 497);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.hTextBox);
            this.Controls.Add(this.XkTextBox);
            this.Controls.Add(this.XnTextBox);
            this.Controls.Add(this.aTextLable);
            this.Controls.Add(this.hTextLable);
            this.Controls.Add(this.XkTextLable);
            this.Controls.Add(this.XnTextLable);
            this.Controls.Add(this.ResultsTextLable);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.Label ResultsTextLable;
        private System.Windows.Forms.Label XnTextLable;
        private System.Windows.Forms.Label XkTextLable;
        private System.Windows.Forms.Label hTextLable;
        private System.Windows.Forms.Label aTextLable;
        private System.Windows.Forms.TextBox XnTextBox;
        private System.Windows.Forms.TextBox XkTextBox;
        private System.Windows.Forms.TextBox hTextBox;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem роботаЗМасивамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OneDimensionalArrayButton;
        private System.Windows.Forms.ToolStripMenuItem TwoDimensionalArrayButton;
        private System.Windows.Forms.ToolStripMenuItem unitTestsToolStripMenuItem;
    }
}

