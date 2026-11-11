using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    internal class Profile : BaseEntity
    {
        [Key]
        public int PID { get; set; }
        public string Logo { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string website { get; set; } = string.Empty;


        // relationships

        [ForeignKey(nameof(Organizer))]
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; } = default!;
    }
}
