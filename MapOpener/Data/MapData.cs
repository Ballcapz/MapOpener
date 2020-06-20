using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MapOpener.Data
{
    public class MapData
    {
        [Required]
        public string Address { get; set; }
        
        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [StringLength(maximumLength: 5, MinimumLength = 5)]
        public string ZipCode { get; set; }
    }
}
