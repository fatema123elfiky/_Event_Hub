using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    internal class Address
    {
        public string city { get; set; } = string.Empty;
        public string street { get; set; } = string.Empty;
        public string postalCode { get; set; } = string.Empty;
        public string country { get; set; } = string.Empty;

    }
}
