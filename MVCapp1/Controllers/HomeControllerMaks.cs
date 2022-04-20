using Microsoft.AspNetCore.Mvc;
using MVCapp1.Models;
using System.Diagnostics;



namespace MVCapp1.Controllers
{
    public class HomeControllerMaks : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Hello");
        }
        [HttpPost]
        public IActionResult Index(Person person)
        {
            return View("HelloName", person);
        }

    }
    
}