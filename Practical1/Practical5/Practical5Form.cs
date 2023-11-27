using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical1.Practical5
{
    public partial class Practical5Form : BaseMenuForm
    {
        public Practical5Form()
        {
            InitializeComponent();

            FlightSchedule = new FlightSchedule();
        }

        private FlightSchedule FlightSchedule;
        const string FilePath = "data.json";

        public void ShowFlightScheduleInDataGrid(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            foreach (var Flight in FlightSchedule.Flights)
            {
                dataGridView.Rows.Add(Flight.FlightNumber, Flight.PlaneType, Flight.Destination);
            }
        }
        private void ReadButton_Click(object sender, EventArgs e)
        {
            var flightSchedule = FlightSchedule.ReadFromFile(FilePath);
            FlightSchedule.Flights = flightSchedule.Flights;


            ShowFlightScheduleInDataGrid(InfoDataGrid);
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            FlightSchedule.SortByDestination();
            ShowFlightScheduleInDataGrid(SortedInfoDataGrid);
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            FlightSchedule.WriteToFile(FilePath);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            FlightSchedule.Flights.Sort();
            ResultInfoDataGrid.Rows.Clear();

            foreach (var Flight in FlightSchedule.Flights)
            {
                if (Flight.PlaneType == SearchTextBox.Text)
                {
                    ResultInfoDataGrid.Rows.Add(Flight.FlightNumber, Flight.PlaneType, Flight.Destination);
                }
            }

        }

        private void AddFlightRandButton_Click(object sender, EventArgs e)
        {
            var flight = new Flight();
            FlightSchedule.Add(flight);

            ShowFlightScheduleInDataGrid(InfoDataGrid);
        }

        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            try
            {
                var num = Convert.ToInt32(NumTextBox.Text);
                
                if (String.IsNullOrEmpty(DesinationTextBox.Text) || String.IsNullOrEmpty(PlaneTypeTextBox.Text)) 
                {
                    throw new Exception("string is null or emmpty");
                }

                var flight = new Flight(DesinationTextBox.Text,num, PlaneTypeTextBox.Text);
                FlightSchedule.Add(flight);

                ShowFlightScheduleInDataGrid(InfoDataGrid);
            }
            catch (Exception ex)
            {             
                MessageBox.Show("Введено не коректні дані.+\n" + ex.Message);
            }
        }
    }
}
