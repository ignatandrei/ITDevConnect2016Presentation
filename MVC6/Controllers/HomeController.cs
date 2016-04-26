using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AMVC6.Models;

namespace AMVC6.Controllers
{
    public class HomeController : Controller
    {
        private IPerson _p;
        public HomeController(IPerson p)
        {
            _p = p;
        }
        public IActionResult Index()
        { 
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Edit(int id)
        {
            var p = new Person();
            p.id = id;
            p.Name = " nume " + id;
            return View(p);
        }
        public IActionResult Verif()
        {
            return Content(" the person " + _p.Name);
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
