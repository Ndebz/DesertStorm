using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DesertStorm.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public DateTime? Year { get; set; }
        public int Tax { get; set; }
        public int MOT { get; set; }
        public string Color { get; set; }
        [Required]
        public Boolean Display { get; set; }
        public int Mileage { get; set; }
        public decimal EngineSize { get; set; }
        [Required]
        public int ModelID { get; set; }


        public virtual Model Model { get; set; }
        public virtual Fuel Fuel { get; set; }
        public virtual Transmission Transmission { get; set; }
        public virtual ICollection<Image> Images { get; set; }

    }
}