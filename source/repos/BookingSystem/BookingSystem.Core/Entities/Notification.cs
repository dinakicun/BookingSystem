using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Core.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookingId { get; set; }
        public string Type { get; set; } = string.Empty;
        public bool IsSent { get; set; }
        public DateTime? SentAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public AppUser User { get; set; } = null!;
        public Booking Booking { get; set; } = null!;
    }
}
