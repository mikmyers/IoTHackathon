using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Entities
{
    public class Location
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Eircode { get; set; }
        public string Phone { get; set; }
        public string XCoOrd { get; set; }
        public string YCoOrd { get; set; }

    }
}