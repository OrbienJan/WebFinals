using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebFinals.Models;

namespace WebFinals.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string userName, int IdNumber)
        {
            ViewBag.Name = userName;
            ViewBag.IdNumber = IdNumber;
            return View();


        }

       

    }
    }
    
