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
    public partial class OneDimensionalArrayForm : BaseMenuForm
    {
        public OneDimensionalArrayForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            try 
            { 
                var n = Convert.ToInt32(ArraySizeTextBox.Text);

                Array1DManager array1D = new Array1DManager(n);
                DisplayArray1D(array1D);


                var result = array1D.CountTemperaturesAboveAverage(array1D.CalculateAverageTemperature());
                ResultLable.Text = result.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void DisplayArray1D(Array1DManager array1D)
        {
            for (int i = 0; i < array1D.Length; i++)
            {
                dataGridView1.Rows.Add(array1D[i].ToString());
            }
        }
    }
}
