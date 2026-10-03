using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OPP_4
{
    internal class Driveer
    {
        public string DriverId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Driveer(string driverId, string name, string phone)
        {
            DriverId = driverId;
            Name = name;
            Phone = phone;
        }
    }
}
