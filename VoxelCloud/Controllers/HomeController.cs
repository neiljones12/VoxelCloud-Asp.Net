using System.Web.Mvc;
using VoxelCloud.App_Start;
using VoxelCloud.Models;

namespace VoxelCloud.Controllers
{
    [AuthorizationFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
             

            return View();
        }
    }
}
