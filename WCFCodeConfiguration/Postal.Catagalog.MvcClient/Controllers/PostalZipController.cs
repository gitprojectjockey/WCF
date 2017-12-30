using System.Web.Mvc;

namespace Postal.Catagalog.MvcClient.Controllers
{
    public class PostalZipController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("PostalZipCodeManager/Ping/{echo}")]
        public ActionResult PingPostalZipCodeManager(string echo)
        {
            PostalZipProxy.PostalZipServiceClient postalZipProxie = new PostalZipProxy.PostalZipServiceClient();
            postalZipProxie.ClientCredentials.UserName.UserName = "TangoTango";
            postalZipProxie.ClientCredentials.UserName.Password = "TangoDown";
            var result = postalZipProxie.Ping(echo);
            return Content(echo);
        }

    }
}