using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DesertStorm.Models
{
    public class DesertStormContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DesertStormContext() : base("name=DesertStormContext")
        {
            Database.SetInitializer<DesertStormContext>(new DesertStormInitializer());
        }

        public System.Data.Entity.DbSet<DesertStorm.Models.Make> Makes { get; set; }
        public System.Data.Entity.DbSet<DesertStorm.Models.Model> Models { get; set; }
        public System.Data.Entity.IDbSet<DesertStorm.Models.Vehicle> Vehicles { get; set; }
    
    }
}
