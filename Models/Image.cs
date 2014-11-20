using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DesertStorm.Models
{
    public class Image
    {
        [Column(Order = 0), Key, ForeignKey("Vehicle")]
        public int VehicleID { get; set; }

        [Column(Order = 1) , Key]
        public string ImageUrl { get; set; }

        public virtual Vehicle Vehicle {get; set;}
    }
}