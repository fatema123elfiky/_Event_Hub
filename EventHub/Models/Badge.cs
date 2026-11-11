using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    internal class Badge : BaseEntity
    {
        public int BID { get; set; }
        public DateTime Date { get; set; }
        public string Tier { get; set; } = string.Empty;

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = default!;
    }
}
