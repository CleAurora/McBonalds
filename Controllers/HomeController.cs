﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hamburgueria.Models;

namespace Hamburgueria.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Home";
            return View();
        }

       
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
