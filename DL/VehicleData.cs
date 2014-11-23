using DesertStorm.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DesertStorm.DL
{
    public class VehicleData
    {
        DesertStormContext db = null;
        public VehicleData(DesertStormContext context)
        {

            this.db = context;

        }

        public IEnumerable<Vehicle> FetchAllVehicles()
        {           
            var vehicles = from v in db.Vehicles
                           from m in db.Makes
                           from mods in db.Models
                           where v.Model.ModelID == mods.ModelID
                           where mods.Make.MakeID == m.MakeID
                           select v;

            return vehicles.ToList();
        }
    }
}