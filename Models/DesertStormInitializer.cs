using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DesertStorm.Models
{
    public class DesertStormInitializer : DropCreateDatabaseAlways<DesertStormContext>
    {
        protected override void Seed(DesertStormContext context)
        {
            IList<Make> defaultMakes = new List<Make>();
            defaultMakes.Add(new Make() { MakeTitle = "Ford"});
            defaultMakes.Add(new Make() { MakeTitle = "Citreon" });
            defaultMakes.Add(new Make() { MakeTitle = "Mazda" });

            foreach(Make make in defaultMakes)
                context.Makes.Add(make);

            IList<Model> defaultModels = new List<Model>();
            defaultModels.Add(new Model() { ModelTitle = "Fiesta" , MakeID = 1});
            defaultModels.Add(new Model() { ModelTitle = "Focus", MakeID = 1 });
            defaultModels.Add(new Model() { ModelTitle = "C3", MakeID = 2 });
            defaultModels.Add(new Model() { ModelTitle = "C4", MakeID = 2 });

            foreach (Model model in defaultModels)
                context.Models.Add(model);

            IList<Vehicle> defaultVehicles = new List<Vehicle>();
            defaultVehicles.Add(new Vehicle() 
                { 
                    ShortDescription = "A beautiful Fiesta",
                    Description = "Sample long description",
                    Price = 20000,
                    Tax = 0,
                    MOT = 0,
                    Color = "Red",
                    Display = true,
                    Mileage = 700000,
                    EngineSize = 2,
                    ModelID = 1
                }
                );
            defaultVehicles.Add(new Vehicle()
                    {
                        ShortDescription = "A lovely Citrieon",
                        Description = "Sample long description",
                        Price = 3500,
                        Tax = 0,
                        MOT = 0,
                        Color = "Yellow",
                        Display = true,
                        Mileage = 700000,
                        EngineSize = 1,
                        ModelID = 4
                    });

            foreach (Vehicle vehicle in defaultVehicles)
                context.Vehicles.Add(vehicle);

            base.Seed(context);
        }
    }
}