using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Core.Entities
{
    public class Workplace
    {
        public int Id { get; set; }
        public int ZoneId { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        public Zone Zone { get; set; } = null!;

    }
}
