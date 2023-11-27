using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1.Practical5
{

    public class Flight : IComparable
    {
        public Flight(string Dest, long FlightNum, string Plane)
        {
            Destination = Dest;
            FlightNumber = FlightNum;
            PlaneType = Plane;
        }
        public Flight()
        {
            Random random = new Random();

            List<string> RandomDestinations = new List<string>() { "New York", "London" , "Paris", "Tokyo" };
            Destination = RandomDestinations[random.Next(RandomDestinations.Count)];

            List<string> RandomPlanes = new List<string>() { "Boeing 747", "Airbus A380", "Boeing 737", "Airbus A320" };
            PlaneType = RandomPlanes[random.Next(RandomPlanes.Count)];

            FlightNumber = random.Next(100, 229);
        }
        public string Destination { get; set; }
        public long FlightNumber { get; set; }
        public string PlaneType { get; set; }
        public int CompareTo(object obj)
        {
            var flight = obj as Flight;
            return flight.PlaneType.CompareTo(PlaneType);
        }
    }
}
