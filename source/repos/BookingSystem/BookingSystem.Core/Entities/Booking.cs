using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Core.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? ZoneId { get; set; }
        public int? WorkplaceId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Status { get; set; } = string.Empty;
        public int? RecurringRuleId { get; set; }
        public DateTime CreatedAt { get; set; }
        public AppUser User { get; set; } = null!;
        public Zone? Zone { get; set; }
        public Workplace? Workplace { get; set; }
        public RecurringRule? RecurringRule { get; set; }
    }
}
