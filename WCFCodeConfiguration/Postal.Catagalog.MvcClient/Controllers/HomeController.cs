using System.Web.Mvc;

namespace Postal.Catagalog.MvcClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}