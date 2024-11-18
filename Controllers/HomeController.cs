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
    }
}
