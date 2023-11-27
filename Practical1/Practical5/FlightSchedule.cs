using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace Practical1.Practical5
{
    public class FlightSchedule
    {
        public FlightSchedule()
        {
            Flights = new List<Flight>();
        }

        [JsonPropertyName("flights")]
        public List<Flight> Flights { get; set; }

        public void Add(Flight flight) => Flights.Add(flight);
        public void Remove(int i) => Flights.RemoveAt(i);

        public void SortByDestination()
        {
            Flights.Sort(new SortByDestination());
        }

        public void WriteToFile(string filePath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(this,options);

            File.WriteAllText(filePath, json);
        }

        public static FlightSchedule ReadFromFile(string filePath)
        {
            string json = File.ReadAllText(filePath);

            var flightSchedule = JsonSerializer.Deserialize<FlightSchedule>(json);
            return flightSchedule;
        }
    }
}
