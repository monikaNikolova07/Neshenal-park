using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neshenal_park.Models
{
    public class Facilities
    {
        public int Id { get; set; }
        public int ZoneId { get; set; }
        public string Type { get; set; }
        public string Material { get; set; }
        public string Condition { get; set; }
        public DateTime InstalledOn { get; set; }

        public Zones Zones { get; set; }
    }
}
