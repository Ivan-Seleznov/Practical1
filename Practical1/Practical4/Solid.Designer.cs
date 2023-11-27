namespace Practical1
{
    partial class Solid
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
            this.ResultArrayLable = new System.Windows.Forms.Label();
            this.InputArrayLable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultArrayLable
            // 
            this.ResultArrayLable.AutoSize = true;
            this.ResultArrayLable.Location = new System.Drawing.Point(49, 214);
            this.ResultArrayLable.Name = "ResultArrayLable";
            this.ResultArrayLable.Size = new System.Drawing.Size(14, 16);
            this.ResultArrayLable.TabIndex = 9;
            this.ResultArrayLable.Text = "0";
            // 
            // InputArrayLable
            // 
            this.InputArrayLable.AutoSize = true;
            this.InputArrayLable.Location = new System.Drawing.Point(49, 114);
            this.InputArrayLable.Name = "InputArrayLable";
            this.InputArrayLable.Size = new System.Drawing.Size(14, 16);
            this.InputArrayLable.TabIndex = 8;
            this.InputArrayLable.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Результуючий масив";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Масив з файлу";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(52, 292);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(193, 40);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Розрахувати";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Solid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultArrayLable);
            this.Controls.Add(this.InputArrayLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateButton);
            this.Name = "Solid";
            this.Text = "Solid";
            this.Controls.SetChildIndex(this.CalculateButton, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.InputArrayLable, 0);
            this.Controls.SetChildIndex(this.ResultArrayLable, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultArrayLable;
        private System.Windows.Forms.Label InputArrayLable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalculateButton;
    }
}