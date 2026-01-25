using Microsoft.AspNetCore.Mvc;

namespace Lesson5_asp_hw.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult ViewDataAction() 
        {
            ViewData["Message"] = "Hello from ViewData!";
            return View();
        }
        public IActionResult ViewBagAction()
        {
            ViewBag.Message = "Hello from ViewBag!";
            return View();
        }
        public IActionResult TempDataAction()
        {
            TempData["Success"] = "Hello from TempData!";
            return View();
        }
    }
}
