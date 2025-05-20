using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neshenal_park.Models
{
    public class PlantSpecies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LatinName { get; set; }
        public bool IsProtected { get; set; }
        public string Description { get; set; }

        public List<ZonePlants> ZonePlants { get; set; } = new List<ZonePlants>();
    }
}
