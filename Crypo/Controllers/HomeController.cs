using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Crypo.Models;
using CrypyData;

namespace Crypo.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            
            return View(JsonUtility.DeserializeJsonClass());
        }

      
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View(JsonUtility.DeserializeJsonHistoric());
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
