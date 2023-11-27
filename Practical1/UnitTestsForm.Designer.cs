namespace Practical1
{
    partial class UnitTestsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Calculate1Button = new System.Windows.Forms.Button();
            this.ResultLable1 = new System.Windows.Forms.Label();
            this.CTextBox1 = new System.Windows.Forms.TextBox();
            this.BTextBox1 = new System.Windows.Forms.TextBox();
            this.ATextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTextBox2 = new System.Windows.Forms.TextBox();
            this.ATextBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CalculateButton2 = new System.Windows.Forms.Button();
            this.ResultLable2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 367);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Calculate1Button);
            this.tabPage1.Controls.Add(this.ResultLable1);
            this.tabPage1.Controls.Add(this.CTextBox1);
            this.tabPage1.Controls.Add(this.BTextBox1);
            this.tabPage1.Controls.Add(this.ATextBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Завдання 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Calculate1Button
            // 
            this.Calculate1Button.Location = new System.Drawing.Point(62, 176);
            this.Calculate1Button.Name = "Calculate1Button";
            this.Calculate1Button.Size = new System.Drawing.Size(150, 28);
            this.Calculate1Button.TabIndex = 8;
            this.Calculate1Button.Text = "Розрахувати";
            this.Calculate1Button.UseVisualStyleBackColor = true;
            this.Calculate1Button.Click += new System.EventHandler(this.Calculate1Button_Click);
            // 
            // ResultLable1
            // 
            this.ResultLable1.AutoSize = true;
            this.ResultLable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLable1.Location = new System.Drawing.Point(44, 227);
            this.ResultLable1.Name = "ResultLable1";
            this.ResultLable1.Size = new System.Drawing.Size(24, 25);
            this.ResultLable1.TabIndex = 7;
            this.ResultLable1.Text = "0";
            // 
            // CTextBox1
            // 
            this.CTextBox1.Location = new System.Drawing.Point(93, 122);
            this.CTextBox1.Name = "CTextBox1";
            this.CTextBox1.Size = new System.Drawing.Size(100, 22);
            this.CTextBox1.TabIndex = 5;
            this.CTextBox1.Text = "81";
            // 
            // BTextBox1
            // 
            this.BTextBox1.Location = new System.Drawing.Point(93, 86);
            this.BTextBox1.Name = "BTextBox1";
            this.BTextBox1.Size = new System.Drawing.Size(100, 22);
            this.BTextBox1.TabIndex = 4;
            this.BTextBox1.Text = "54";
            // 
            // ATextBox1
            // 
            this.ATextBox1.Location = new System.Drawing.Point(93, 52);
            this.ATextBox1.Name = "ATextBox1";
            this.ATextBox1.Size = new System.Drawing.Size(100, 22);
            this.ATextBox1.TabIndex = 3;
            this.ATextBox1.Text = "27";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(46, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "c:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "b:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "a:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ResultLable2);
            this.tabPage2.Controls.Add(this.CalculateButton2);
            this.tabPage2.Controls.Add(this.BTextBox2);
            this.tabPage2.Controls.Add(this.ATextBox2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Завдання 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTextBox2
            // 
            this.BTextBox2.Location = new System.Drawing.Point(74, 69);
            this.BTextBox2.Name = "BTextBox2";
            this.BTextBox2.Size = new System.Drawing.Size(100, 22);
            this.BTextBox2.TabIndex = 8;
            this.BTextBox2.Text = "1000";
            // 
            // ATextBox2
            // 
            this.ATextBox2.Location = new System.Drawing.Point(74, 35);
            this.ATextBox2.Name = "ATextBox2";
            this.ATextBox2.Size = new System.Drawing.Size(100, 22);
            this.ATextBox2.TabIndex = 7;
            this.ATextBox2.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(27, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "b:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(27, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "a:";
            // 
            // CalculateButton2
            // 
            this.CalculateButton2.Location = new System.Drawing.Point(74, 153);
            this.CalculateButton2.Name = "CalculateButton2";
            this.CalculateButton2.Size = new System.Drawing.Size(150, 28);
            this.CalculateButton2.TabIndex = 9;
            this.CalculateButton2.Text = "Розрахувати";
            this.CalculateButton2.UseVisualStyleBackColor = true;
            this.CalculateButton2.Click += new System.EventHandler(this.CalculateButton2_Click);
            // 
            // ResultLable2
            // 
            this.ResultLable2.AutoSize = true;
            this.ResultLable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLable2.Location = new System.Drawing.Point(25, 233);
            this.ResultLable2.Name = "ResultLable2";
            this.ResultLable2.Size = new System.Drawing.Size(24, 25);
            this.ResultLable2.TabIndex = 10;
            this.ResultLable2.Text = "0";
            // 
            // UnitTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "UnitTestsForm";
            this.Text = "UnitTestsForm";
            this.Load += new System.EventHandler(this.UnitTestsForm_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Calculate1Button;
        private System.Windows.Forms.Label ResultLable1;
        private System.Windows.Forms.TextBox CTextBox1;
        private System.Windows.Forms.TextBox BTextBox1;
        private System.Windows.Forms.TextBox ATextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ResultLable2;
        private System.Windows.Forms.Button CalculateButton2;
        private System.Windows.Forms.TextBox BTextBox2;
        private System.Windows.Forms.TextBox ATextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}