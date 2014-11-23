using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DesertStorm.Models
{
    public class Fuel
    {
        public int FuelID { get; set; }
        [Required]
        public string FuelType { get; set; }
    }
}
