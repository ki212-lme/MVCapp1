using Microsoft.AspNetCore.Mvc;
using MVCapp1.Models;
using System.Diagnostics;

namespace MVCapp1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Hello() {
            return View();
        }
        [HttpPost]
        public IActionResult Hello(Person person) {
 
            return View("HelloName",person);
        }
    }
}