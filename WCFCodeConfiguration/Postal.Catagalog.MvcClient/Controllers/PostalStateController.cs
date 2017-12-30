using System.Web.Mvc;
using Postal.Catagalog.MvcClient.ViewModels;
using System.Linq;

namespace Postal.Catagalog.MvcClient.Controllers
{
    [RoutePrefix("api/GoPostal")]
    public class PostalStateController : Controller
    {
        [HttpGet]
        public ActionResult Index(bool primaryOnly = true)
        {
            
            PostalStateProxy.PostalStateServiceClient postalStateProxie = new PostalStateProxy.PostalStateServiceClient();
            postalStateProxie.ClientCredentials.UserName.UserName = "TangoTango";
            postalStateProxie.ClientCredentials.UserName.Password = "TangoDown";
            string[] results = postalStateProxie.GetStates(primaryOnly);
            var model = new StateViewModel()
            {
                States = results.OrderBy(s => s).ToArray()
            };
            return View(model);
        }

        [HttpGet]
        [Route("PostalStateCodeManager/Ping/{echo}")]
        public ActionResult PingPostalStateCodeManager(string echo)
        {
            PostalStateProxy.PostalStateServiceClient postalStateProxie = new PostalStateProxy.PostalStateServiceClient();
            postalStateProxie.ClientCredentials.UserName.UserName = "TangoTango";
            postalStateProxie.ClientCredentials.UserName.Password = "TangoDown";
            var result = postalStateProxie.Ping(echo);
            return Content(echo);
        }

        [HttpGet]
        [Route("PostalStateCodeManager/StateCode/{stateAbbrev}")]
        public PartialViewResult StateCode(string stateAbbrev)
        {
            try
            {
                PostalStateProxy.PostalStateServiceClient postalStateProxie = new PostalStateProxy.PostalStateServiceClient();
                postalStateProxie.ClientCredentials.UserName.UserName = "TangoTango";
                postalStateProxie.ClientCredentials.UserName.Password = "TangoDown";
                PostalStateProxy.StateCodeData result = postalStateProxie.GetStateCode(stateAbbrev);
                var model = new PostalStateCodeViewModel()
                {
                    Abbreviation = result.Abbreviation,
                    Name = result.Name,
                    SSCode = result.SSCode,
                    StateId = result.StateId
                };
                return PartialView("_StateDetail", model);
            }
            catch
            {
                var model = new PostalStateCodeViewModel()
                {
                    ExceptionMessage = "Could not process request."
                };

                return PartialView("_StateDetail", model);
            }
        }
    }
}