using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DiffProject.Controllers
{
    public class GETController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
