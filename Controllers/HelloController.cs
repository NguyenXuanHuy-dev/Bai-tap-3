using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bai1.Models;

namespace bai1.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "thằng nào đọc cái này là gay";
            ViewBag.date = DateTime.Now;
            return View();
        }
    }
}
