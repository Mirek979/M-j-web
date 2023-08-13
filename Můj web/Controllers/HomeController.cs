using Microsoft.AspNetCore.Mvc;
using Můj_web.Models;
using System.Diagnostics;

namespace Můj_web.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Reference()
        {
            return View();
        }

        public IActionResult Skills()
        {
            return View();
        }
    }
}