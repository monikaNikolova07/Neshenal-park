using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neshenal_park.Models
{
    public class ZonePlants
    {
        public int Id { get; set; }
        public int ZoneId { get; set; }
        public int PlantId { get; set; }
        public double Density { get; set; }

        public Zones Zones { get; set; }
        public PlantSpecies PlantSpecies { get; set; }
    }
}
