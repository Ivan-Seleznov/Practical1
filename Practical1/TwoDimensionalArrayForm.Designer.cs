namespace Practical1
{
    partial class TwoDimensionalArrayForm
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultLable = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RowsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(622, 82);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(145, 49);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Обрахувати";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Кількість від‘ємних елементів, розташованих нижче лівої діагоналі:";
            // 
            // ResultLable
            // 
            this.ResultLable.AutoSize = true;
            this.ResultLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLable.Location = new System.Drawing.Point(334, 180);
            this.ResultLable.Name = "ResultLable";
            this.ResultLable.Size = new System.Drawing.Size(17, 18);
            this.ResultLable.TabIndex = 9;
            this.ResultLable.Text = "0";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(314, 371);
            this.dataGridView1.TabIndex = 10;
            // 
            // ColsTextBox
            // 
            this.ColsTextBox.Location = new System.Drawing.Point(428, 110);
            this.ColsTextBox.Name = "ColsTextBox";
            this.ColsTextBox.Size = new System.Drawing.Size(100, 22);
            this.ColsTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(339, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cols =";
            // 
            // RowsTextBox
            // 
            this.RowsTextBox.Location = new System.Drawing.Point(428, 72);
            this.RowsTextBox.Name = "RowsTextBox";
            this.RowsTextBox.Size = new System.Drawing.Size(100, 22);
            this.RowsTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(339, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rows =";
            // 
            // TwoDimensionalArrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ColsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RowsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ResultLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalculateButton);
            this.Name = "TwoDimensionalArrayForm";
            this.Text = "TwoDimensionalArrayForm";
            this.Controls.SetChildIndex(this.CalculateButton, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ResultLable, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.RowsTextBox, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.ColsTextBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ResultLable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ColsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RowsTextBox;
        private System.Windows.Forms.Label label3;
    }
}