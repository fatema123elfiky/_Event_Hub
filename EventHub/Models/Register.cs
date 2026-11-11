using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    internal class Register : BaseEntity
    {
     
        public int EventId { get; set; }
        public Event Event { get; set; } = default!;
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = default!;

        // properties
        public string ShortNote { get; set; } = string.Empty;
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
    }
}
