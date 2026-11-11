using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    [Table("Organizers")]
    internal class Organizer : BaseEntity
    {
        [Key]
        public int OID { get; set; }
        public string Name { get; set; }= string.Empty;
        public bool status { get; set; }
        
        [Required]
        public string CompanyName { get; set; } = string.Empty;
       
        // relationships

        public Profile Profile { get; set; } = default!;

        public ICollection<Event> Events { get; set; } = new HashSet<Event>();
    }
}
