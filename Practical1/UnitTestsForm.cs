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
    public partial class UnitTestsForm : BaseMenuForm
    {
        public UnitTestsForm()
        {
            InitializeComponent();
        }

        private void UnitTestsForm_Load(object sender, EventArgs e)
        {

        }

        private void Calculate1Button_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(ATextBox1.Text);
                int b = Convert.ToInt32(BTextBox1.Text);
                int c = Convert.ToInt32(CTextBox1.Text);

                CountMultiples calculateABC = new CountMultiples(a,b,c);
                ResultLable1.Text = calculateABC.CountMultiplesOf27().ToString();
            }
            catch 
            {
                MessageBox.Show("Введені некоректні дані");
            }
        }

        private void CalculateButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(ATextBox2.Text);
                int b = Convert.ToInt32(BTextBox2.Text);

                CalculationAB calculationAB = new CalculationAB(a,b);
                ResultLable2.Text = calculationAB.CountNumbers().ToString();
            }
            catch
            {
                MessageBox.Show("Введені некоректні дані");
            }
        }
    }
}
