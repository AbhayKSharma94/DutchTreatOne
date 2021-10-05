using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;



namespace DutchTreat.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            throw new InvalidProgramException("Bad things happen to good developers");

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
                return View();
        }
    }
}


//What the view represents isnt HTML, but its called Razor
//Razor is a syntax for doing replacements and adding a small amount of view logic in C#
