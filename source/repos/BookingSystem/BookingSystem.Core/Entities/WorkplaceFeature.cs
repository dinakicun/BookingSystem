using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Core.Entities
{
    public class WorkplaceFeature
    {
        public int WorkplaceId { get; set; }
        public int FeatureId { get; set; }
        public Workplace Workplace { get; set; } = null!;
        public Feature Feature { get; set; } = null!;
    }
}
