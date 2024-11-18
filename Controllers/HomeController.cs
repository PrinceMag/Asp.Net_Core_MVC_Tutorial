using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_MVC_Tutorial.Controllers
{
    public class HomeController : Controller
    {
        //View name and action method is same

        public ViewResult About()
        {
            return View();
        }

        //View name and action method is different
        public ViewResult Contact()
        {
            return View("ContactUs");
        }

        //View resides in shared folder
        public ViewResult Product()
        {
            return View();
        }

        //displaying view of different controller
        public ViewResult Display()
        {
            return View("~/Views/Account/Dashboard.cshtml");
        }


        //localhost/home/index
        public ViewResult Index()
        {
            return View();
        }

        //RedirectResult to internal url
        public RedirectResult ShowInternal()
        {
            return Redirect("/home/index");
        }

        //RedirectResult to external url
        public RedirectResult ShowExternal()
        {
            return Redirect("http://www.google.com");
        }

        public RedirectToActionResult ShowContact()
        {
            //return RedirectToRoute(new { controller = "Home", action = "contact" });
            return RedirectToAction("contact");
        }

        public RedirectToActionResult SignUp()
        {
            return RedirectToAction("Register", "Account");
        }

        private void TestAnonymous()
        {
            var s1 = new
            {
                rollno = 5,
                name = "Prince"
            };
        }

        //using action method
        [ActionName("testimonials")]
        public ViewResult Testimony()
        {
            return View("Testimony");
        }

        //non action method
        [NonAction]
        public string Greet()
        {
            return "Hello World!";
        }

        [HttpGet]
        public ViewResult Help()
        {
            return View();
        }

        //Action parameter
        public ViewResult List()
        {
            return View();
        }

        public ContentResult Details()
        {
            int x = Convert.ToInt32(Request.Query["id"]);
            string country = "";
            switch (x)
            {
                case 1: country = "South Africa"; break;
                case 2: country = "Zimbabwe"; break;
                case 3: country = "South Africa"; break;
                default:
                    country = "Sorry, you do not belong to any country";
                    break;
            }
            return Content(country);
        }
    }
}
