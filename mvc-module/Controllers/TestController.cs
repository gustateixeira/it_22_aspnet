using Microsoft.AspNetCore.Mvc;

namespace mvc_module.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }    

}