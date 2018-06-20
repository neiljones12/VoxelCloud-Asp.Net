using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VoxelCloud.Models;

namespace VoxelCloud.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            var db = new Context();
            var dbCheck = db.Database.Exists();

            // If true, the database does not exist
            if (!dbCheck)
            {
                db.Database.Create();
            }


            return View();
        }
    }
}
