using VoxelCloud.Helpers;
using System.Web.Mvc;
using VoxelCloud.Models;
using VoxelCloud.Models.ViewModels;

namespace VoxelCloud.Controllers
{
    //[AuthorizationFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new Context();
            var dbCheck = db.Database.Exists();

            var model = new HomeViewModel();

            // If true, the database does not exist
            if (!dbCheck)
            {
                db.Database.Create();
                Initialize();
                model.Message = "Database 'HVAC' created";
            }

            if(model.Message == string.Empty)
                model.Message = "Database 'HVAC' Already Exists";

            return View(model);
        }

        // Initializing the database with some data
        private void Initialize()
        {
            var db = new Context();

            var listHelper = new ListHelper();

            var locations = listHelper.LocationList();
            foreach (var l in locations)
            {
                db.Location.Add(l);
            }

            var customers = listHelper.CustomerList();
            foreach (var c in customers)
            {
                db.Customer.Add(c);
            }

            var Devices = listHelper.DeviceList();
            foreach (var p in Devices)
            {
                db.Device.Add(p);
            }

            var customerLocation = listHelper.CustomerLocationList();
            foreach (var c in customerLocation)
            {
                db.CustomerLocation.Add(c);
            }

            var customerDevice = listHelper.CustomerDeviceList();
            foreach (var c in customerDevice)
            {
                db.CustomerDevice.Add(c);
            }

            var deviceLogs = listHelper.DeviceEventList();
            foreach (var d in deviceLogs)
            {
                db.DeviceEvent.Add(d);
            }
            

            db.SaveChanges();
        }
    }
}
