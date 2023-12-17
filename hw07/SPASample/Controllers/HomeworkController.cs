using Microsoft.AspNetCore.Mvc;

namespace SPASample.Controllers
{
    public class HomeworkController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Cat()
        {
            return View();
        }
        public IActionResult Dog()
        {
            return View();
        }
    }
}
