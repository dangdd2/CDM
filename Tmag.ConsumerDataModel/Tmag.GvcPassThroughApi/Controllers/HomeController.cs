using System.Web.Mvc;

namespace Tmag.GvcPassThroughApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "";
            return View();
        }
    }
}
