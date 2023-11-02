using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Tabul tabul1 = new Tabul();

            double xn = 0, xk = 0, h = 0 , a = 0;
            try
            {
                xn = Convert.ToDouble(XnTextBox.Text);
                xk = Convert.ToDouble(XkTextBox.Text);
                h = Convert.ToDouble(hTextBox.Text);
                a = Convert.ToDouble(aTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Введіть коректні дані\n {ex.Message}");
                return;
            }

            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();
            tabul1.Tab(xn, xk, h, a);

            for (int i = 0; i < tabul1.n; i++)
            {
                dataGridView1.Rows.Add(Math.Round(tabul1.xy[i, 0], 2), Math.Round(tabul1.xy[i, 1], 3));
                chart1.Series[0].Points.AddXY(tabul1.xy[i, 0], tabul1.xy[i,1]);
            }
        }

        private void OneDimensionalArrayButton_Click(object sender, EventArgs e)
        {
            BaseMenuForm OneDimensionalArrayForm = new OneDimensionalArrayForm();
            ShowMenuForm(OneDimensionalArrayForm);
        }

        private void TwoDimensionalArrayButton_Click(object sender, EventArgs e)
        {
            BaseMenuForm TwoDimensionalArrayForm = new TwoDimensionalArrayForm();
            ShowMenuForm(TwoDimensionalArrayForm);
        }

        private void ShowMenuForm(BaseMenuForm menuForm)
        {
            menuForm.Show();
            Hide();
        }

        private void unitTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseMenuForm unitTestsForm = new UnitTestsForm();
            ShowMenuForm(unitTestsForm);
        }
    }
}
