namespace Practical1.Practical5
{
    partial class Practical5Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DesinationTextBox = new System.Windows.Forms.TextBox();
            this.NumTextBox = new System.Windows.Forms.TextBox();
            this.PlaneTypeTextBox = new System.Windows.Forms.TextBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ResultInfoDataGrid = new System.Windows.Forms.DataGridView();
            this.FlightNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaneType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddFlightButton = new System.Windows.Forms.Button();
            this.AddFlightRandButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.WriteButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.InfoDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SortedInfoDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ResultInfoDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortedInfoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введеня даних";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пункт призначення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер рейсу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип літака";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип літака";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Інформація";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(914, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Відсортована інформація";
            // 
            // DesinationTextBox
            // 
            this.DesinationTextBox.Location = new System.Drawing.Point(190, 74);
            this.DesinationTextBox.Name = "DesinationTextBox";
            this.DesinationTextBox.Size = new System.Drawing.Size(100, 22);
            this.DesinationTextBox.TabIndex = 7;
            // 
            // NumTextBox
            // 
            this.NumTextBox.Location = new System.Drawing.Point(190, 104);
            this.NumTextBox.Name = "NumTextBox";
            this.NumTextBox.Size = new System.Drawing.Size(100, 22);
            this.NumTextBox.TabIndex = 8;
            // 
            // PlaneTypeTextBox
            // 
            this.PlaneTypeTextBox.Location = new System.Drawing.Point(190, 136);
            this.PlaneTypeTextBox.Name = "PlaneTypeTextBox";
            this.PlaneTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.PlaneTypeTextBox.TabIndex = 9;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(190, 252);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(100, 22);
            this.SearchTextBox.TabIndex = 10;
            // 
            // ResultInfoDataGrid
            // 
            this.ResultInfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultInfoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlightNumber,
            this.PlaneType,
            this.Destination});
            this.ResultInfoDataGrid.Location = new System.Drawing.Point(12, 334);
            this.ResultInfoDataGrid.Name = "ResultInfoDataGrid";
            this.ResultInfoDataGrid.RowHeadersWidth = 51;
            this.ResultInfoDataGrid.RowTemplate.Height = 24;
            this.ResultInfoDataGrid.Size = new System.Drawing.Size(306, 187);
            this.ResultInfoDataGrid.TabIndex = 11;
            // 
            // FlightNumber
            // 
            this.FlightNumber.HeaderText = "Номер рейсу";
            this.FlightNumber.MinimumWidth = 6;
            this.FlightNumber.Name = "FlightNumber";
            this.FlightNumber.Width = 125;
            // 
            // PlaneType
            // 
            this.PlaneType.HeaderText = "Тип літака";
            this.PlaneType.MinimumWidth = 6;
            this.PlaneType.Name = "PlaneType";
            this.PlaneType.Width = 125;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Пункт призначення";
            this.Destination.MinimumWidth = 6;
            this.Destination.Name = "Destination";
            this.Destination.Width = 125;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(72, 296);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(170, 23);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Пошук";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddFlightButton
            // 
            this.AddFlightButton.Location = new System.Drawing.Point(37, 176);
            this.AddFlightButton.Name = "AddFlightButton";
            this.AddFlightButton.Size = new System.Drawing.Size(101, 23);
            this.AddFlightButton.TabIndex = 13;
            this.AddFlightButton.Text = "Додати";
            this.AddFlightButton.UseVisualStyleBackColor = true;
            this.AddFlightButton.Click += new System.EventHandler(this.AddFlightButton_Click);
            // 
            // AddFlightRandButton
            // 
            this.AddFlightRandButton.Location = new System.Drawing.Point(189, 176);
            this.AddFlightRandButton.Name = "AddFlightRandButton";
            this.AddFlightRandButton.Size = new System.Drawing.Size(101, 23);
            this.AddFlightRandButton.TabIndex = 14;
            this.AddFlightRandButton.Text = "Додати (rand)";
            this.AddFlightRandButton.UseVisualStyleBackColor = true;
            this.AddFlightRandButton.Click += new System.EventHandler(this.AddFlightRandButton_Click);
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(12, 565);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(179, 27);
            this.ReadButton.TabIndex = 17;
            this.ReadButton.Text = "Читання";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // WriteButton
            // 
            this.WriteButton.Location = new System.Drawing.Point(216, 565);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(179, 27);
            this.WriteButton.TabIndex = 18;
            this.WriteButton.Text = "Запис";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(424, 565);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(179, 27);
            this.RemoveButton.TabIndex = 19;
            this.RemoveButton.Text = "Видалити";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(770, 565);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(179, 27);
            this.SortButton.TabIndex = 20;
            this.SortButton.Text = "Сортування";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // InfoDataGrid
            // 
            this.InfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.InfoDataGrid.Location = new System.Drawing.Point(335, 74);
            this.InfoDataGrid.Name = "InfoDataGrid";
            this.InfoDataGrid.RowHeadersWidth = 51;
            this.InfoDataGrid.RowTemplate.Height = 24;
            this.InfoDataGrid.Size = new System.Drawing.Size(346, 447);
            this.InfoDataGrid.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер рейсу";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип літака";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Пункт призначення";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // SortedInfoDataGrid
            // 
            this.SortedInfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SortedInfoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.SortedInfoDataGrid.Location = new System.Drawing.Point(794, 74);
            this.SortedInfoDataGrid.Name = "SortedInfoDataGrid";
            this.SortedInfoDataGrid.RowHeadersWidth = 51;
            this.SortedInfoDataGrid.RowTemplate.Height = 24;
            this.SortedInfoDataGrid.Size = new System.Drawing.Size(356, 447);
            this.SortedInfoDataGrid.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Номер рейсу";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Тип літака";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Пункт призначення";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // Practical5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 621);
            this.Controls.Add(this.SortedInfoDataGrid);
            this.Controls.Add(this.InfoDataGrid);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.WriteButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.AddFlightRandButton);
            this.Controls.Add(this.AddFlightButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ResultInfoDataGrid);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.PlaneTypeTextBox);
            this.Controls.Add(this.NumTextBox);
            this.Controls.Add(this.DesinationTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Practical5Form";
            this.Text = "Practical5Form";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.DesinationTextBox, 0);
            this.Controls.SetChildIndex(this.NumTextBox, 0);
            this.Controls.SetChildIndex(this.PlaneTypeTextBox, 0);
            this.Controls.SetChildIndex(this.SearchTextBox, 0);
            this.Controls.SetChildIndex(this.ResultInfoDataGrid, 0);
            this.Controls.SetChildIndex(this.SearchButton, 0);
            this.Controls.SetChildIndex(this.AddFlightButton, 0);
            this.Controls.SetChildIndex(this.AddFlightRandButton, 0);
            this.Controls.SetChildIndex(this.ReadButton, 0);
            this.Controls.SetChildIndex(this.WriteButton, 0);
            this.Controls.SetChildIndex(this.RemoveButton, 0);
            this.Controls.SetChildIndex(this.SortButton, 0);
            this.Controls.SetChildIndex(this.InfoDataGrid, 0);
            this.Controls.SetChildIndex(this.SortedInfoDataGrid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ResultInfoDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortedInfoDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DesinationTextBox;
        private System.Windows.Forms.TextBox NumTextBox;
        private System.Windows.Forms.TextBox PlaneTypeTextBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView ResultInfoDataGrid;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddFlightButton;
        private System.Windows.Forms.Button AddFlightRandButton;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaneType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridView InfoDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView SortedInfoDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}