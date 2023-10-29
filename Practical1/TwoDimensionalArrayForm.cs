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
    public partial class TwoDimensionalArrayForm : BaseMenuForm
    {
        public TwoDimensionalArrayForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            
            try
            {
                int rows = 0, cols = 0;

                rows = Convert.ToInt32(RowsTextBox.Text);
                cols = Convert.ToInt32(ColsTextBox.Text);

                Array2DManager array2D = new Array2DManager(rows,cols);
                DisplayArray2D(array2D);

                var result = array2D.CountNegativeBelowDiagonal();
                ResultLable.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DisplayArray2D(Array2DManager array2D)
        {
            for (int i = 0; i < array2D.ColsCount; i++)
            {
                dataGridView1.Columns.Add("Column" + i, "Column" + i);
            }

            for (int i = 0; i < array2D.RowsCount; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < array2D.ColsCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = array2D[i, j];
                }
            }
        }
    }
}
