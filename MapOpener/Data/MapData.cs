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
    }
}
