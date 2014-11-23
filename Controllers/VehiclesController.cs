using DesertStorm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesertStorm.Controllers
{
    public class VehiclesController : Controller
    {
        private DesertStormContext db = new DesertStormContext();

        public ActionResult Index()
        {
            return View(db.Vehicles.ToList());
        }
	}
}