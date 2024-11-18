using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_MVC.Controllers
{
    public class ContentController : Controller
    {
        public ContentResult Greet()
        {
            return Content("Hello Everyone");
        }

        public string Say()
        {
            return "Good Bye";
        }

        public int Add()
        {
            int x = 6, y = 4;
            int z = x + y;
            return z;
        }
    }
}
