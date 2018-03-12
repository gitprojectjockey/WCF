using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Postal.Catagalog.MvcClient.IdentityFactories;
using Postal.Catagalog.MvcClient.IdentityModels;
using Postal.Catagalog.MvcClient.Models;
using System;
using System.Threading.Tasks;
using System.Web;

using System.Web.Mvc;
using System.Web.Routing;

namespace Postal.Catagalog.MvcClient.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        //First we'll make the UserManager<AppDbIdentityUser> instance accessible from the  AuthController:
        //Could use DI container here
        //We also dispose of user manager below.
        private readonly UserManager<AppDbIdentityUser> userManager;

        public AuthController() : this(UserManagerFactory.Create()) { }

        public AuthController(UserManager<AppDbIdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public ActionResult Login(string returnUrl, bool registrationSuccessful = false)
        {
            var model = new LoginModel
            {
                ReturnUrl = returnUrl,
                RegistrationSuccessful = registrationSuccessful
            };

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> LoginAsync(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Login");
            }

            var user = await userManager.FindAsync(model.Email, model.Password);

            if (user != null)
            {
                var identity = await userManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);

                var authManager = GetAuthenticationManager(Request);
                authManager.SignIn(identity);

                return Redirect(GetRedirectUrl(model.ReturnUrl,this));
            }

            ModelState.AddModelError("", "Invalid email or password");
            return View("Login");
        }

        [HttpGet]
        public ActionResult Logout()
        {
            var authManager = GetAuthenticationManager(Request);
            authManager.SignOut();

            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public async Task<ActionResult> RegisterAsync(RegistrationModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Register");
            }

            var user = new AppDbIdentityUser
            {
                UserName = model.Email,
                Country = model.Country,
                Email = model.Email
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Login", new RouteValueDictionary(new { returnUrl = GetRedirectUrl("", this), registrationSuccessful = true }));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }

            return View("Register");
        }

        private static Func<HttpRequestBase, IAuthenticationManager> GetAuthenticationManager = (request) =>
        {
            var ctx = request.GetOwinContext();
            return ctx.Authentication;
        };

        private static Func<string,Controller,string > GetRedirectUrl = (returnUrl, authController) =>
        {
            if (string.IsNullOrEmpty(returnUrl) || !authController.Url.IsLocalUrl(returnUrl))
            {
                return authController.Url.Action("index", "home");
            }
            return returnUrl;
        };

        protected override void Dispose(bool disposing)
        {
            if (disposing && userManager != null)
            {
                userManager.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}