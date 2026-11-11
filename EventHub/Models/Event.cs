using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    internal class Event : BaseEntity
    {
        
        public int EID { get; set; }
        public string Title { get; set; } = string.Empty;
        public int MaxNumberOfAttendees { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // relationships

        [ForeignKey(nameof(Organizer))]
        public int OID { get; set; }
        public Organizer Organizer { get; set; } = default!;

        public ICollection<Register> Registers { get; set; } = new HashSet<Register>();

        public int ConfEID { get; set; }
        public Event? Conference { get; set; }
    }
}
