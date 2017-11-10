using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainMidlandsFly.Models
{
    public class Crew
    {
        public int ID { get; set; }
        public string CrewID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Type { get; set; }
    }
}
