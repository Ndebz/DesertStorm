using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DesertStorm.Models
{
    public class Transmission
    {
        public int TransmissionID { get; set; }

        [Required]
        public string TransmissionType { get; set; }
    }
}
