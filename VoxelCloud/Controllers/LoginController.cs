using VoxelCloud.Helpers;
using System.Web.Mvc;
using VoxelCloud.Models;

namespace VoxelCloud.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            var db = new Context();
            var dbCheck = db.Database.Exists();

            // If true, the database does not exist
            if (!dbCheck)
            {
                db.Database.Create();
                Initialize();
            }

            return View();
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

            var products = listHelper.ProductList();
            foreach (var p in products)
            {
                db.Product.Add(p);
            }

            var customerLocation = listHelper.CustomerLocationList();
            foreach (var c in customerLocation)
            {
                db.CustomerLocation.Add(c);
            }

            var customerProduct = listHelper.CustomerProductList();
            foreach (var c in customerProduct)
            {
                db.CustomerProduct.Add(c);
            }

            db.SaveChanges();
        }
    }
}