using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    internal class Attendee : BaseEntity
    {
        public int AID { get; set; }
        
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Address Address { get; set; } = default!;


        public Badge Badge { get; set; } = default!;
        public ICollection<Register> Registers { get; set; } = new HashSet<Register>();

    }
}
