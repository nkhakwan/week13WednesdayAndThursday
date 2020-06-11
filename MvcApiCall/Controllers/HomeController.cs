using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcApiCall.Models;

namespace MvcApiCall.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Places");
        }
    }
}





/*using Microsoft.AspNetCore.Mvc;
using MvcApiCall.Models;
using System;

namespace MvcApiCall.Controllers
{
  public class HomeController : Controller
    {
        using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CretaceousClient.Models;

namespace CretaceousClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Animals");
        }
    }
}

        public IActionResult Index()
{
        var allPlaces = Place.GetPlaces();
        return View(allPlaces);
}
    }

    
}*/
