using Microsoft.AspNetCore.Mvc;

namespace BookMvc.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "This is my hello world default page.";
        //}

        public string Welcome()
        {
            return "This is my welcome page.";
        }
    }
}
