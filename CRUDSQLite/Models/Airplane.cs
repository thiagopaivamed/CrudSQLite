using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDSQLite.Models
{
    public class Airplane
    {
        public int AirplaneId { get; set; }

        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public int Passengers { get; set; }
    }
}
