using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DesertStorm.Models
{
    public class Body
    {
        public int BodyID { get; set; }
        [Required]
        public string BodyType { get; set; }
    }
}
