using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Neshenal_park.Models
{
    public class Zones
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double AreaHa { get; set; }

        public List<Facilities> Facilities { get; set; } = new List<Facilities>();
        public List<ZonePlants> ZonePlants { get; set; } = new List<ZonePlants>();
    }
}
