using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_MVC_Tutorial.Controllers
{
    public class AccountController : Controller
    {
        public ViewResult Dashboard()
        {
            return View();
        }

        public ViewResult Register()
        {
            return View();
        }

        public ViewResult Login()
        {
            return View();
        }


        [HttpPost]
        public ContentResult Validate()
        {
            string s = Request.Form["uname"];
            string p = Request.Form["pass"];

            if (s == "prince" && p == "prince") // Simplified check. In real-world scenarios, always use hashed passwords.
            {
                return Content("Welcome");
            }
            else
            {
                return Content("Sorry, invalid username or password.");
            }
        }

        public ContentResult Validatee(IFormCollection values)
        {
            string u = values["uname"];
            string p = values["pass"];
            if (u == "prince" && p == "prince") // Simplified check. In real-world scenarios, always use hashed passwords.
            {
                return Content("Welcome");
            }
            else
            {
                return Content("Sorry, invalid username or password.");
            }

        }
    }
}
