using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Core.Entities
{
    public class ZoneFeature
    {
        public int ZoneId { get; set; }
        public int FeatureId { get; set; }
        public Zone Zone { get; set; } = null!;
        public Feature Feature { get; set; } = null!;
    }
}
