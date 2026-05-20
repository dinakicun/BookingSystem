using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Core.Entities
{
    public class RecurringRule
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? ZoneId { get; set; }
        public int? WorkplaceId { get; set; }
        public int DayOfWeek { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public bool IsActive { get; set; }
        public AppUser User { get; set; } = null!;
        public Zone? Zone { get; set; }
        public Workplace? Workplace { get; set; }
    }
}
