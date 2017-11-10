using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainMidlandsFly.Models
{
    public class Flight
    {
        public int ID { get; set; }
        public string FlightID { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int DistanceTravelled { get; set; }
    }
}
