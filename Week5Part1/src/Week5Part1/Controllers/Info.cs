using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.ViewFeatures;

namespace Week5Part1.Controllers
{
    public class Info : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}