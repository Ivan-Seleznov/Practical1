using Practical1.Practical4;
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
    public partial class Solid : BaseMenuForm
    {
        const string ResultFilePath = "pr4\\result.txt";
        const string InputFilePath = "pr4\\input.txt";

        private CustomIntArray InputArray;


        public Solid()
        {
            InitializeComponent();

            InputArray = new CustomIntArray();

            ReadInputArray();
        }


        private void CalculateButton_Click(object sender, EventArgs e)
        {
            ReadInputArray();

            InputArray.MoveSecondNonZeroElementToFront();

            WriteResultArray(InputArray);
        }

        void ReadInputArray()
        {
            try
            {
                TxtFileReader txtFileReader = new TxtFileReader();
                InputArray = new CustomIntArray(txtFileReader.ReadArray<int>(InputFilePath).ToList());

                if (InputArray == null || InputArray.Count() == 0)
                {
                    throw new Exception("Array is null or empty");
                }

                InputArrayLable.Text = InputArray.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка читання з файлу.\n" + ex.Message);
            }
        }

        void WriteResultArray(CustomIntArray resultArray)
        {
            try
            {
                TxtFileWriter txtFileWriter = new TxtFileWriter();
                txtFileWriter.WriteArray(ResultFilePath, resultArray);

                ResultArrayLable.Text = resultArray.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка запису у файл\n" + ex.Message);
                throw;
            }
        }
    }
}
