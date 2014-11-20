using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesertStorm.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public DateTime MyProperty { get; set; }
        public int Tax { get; set; }
        public int MOT { get; set; }
        public string Color { get; set; }
        public Boolean Display { get; set; }
        public int Mileage { get; set; }
        public decimal Price { get; set; }
        public decimal EngineSize { get; set; }

        public virtual Model Model { get; set; }
        public virtual Fuel Fuel { get; set; }
        public virtual Transmission Transmission { get; set; }
    }
}