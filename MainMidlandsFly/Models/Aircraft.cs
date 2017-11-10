using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainMidlandsFly.Models
{
    public class Aircraft
    {
        public int ID { get; set; }
        public string AircraftID { get; set; }
        public string Colour { get; set; }
        public string Type { get; set; }
        public string MaxSeat { get; set; }
        public string MaxCarry { get; set; }

    }
}
