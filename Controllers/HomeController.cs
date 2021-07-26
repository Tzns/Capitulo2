using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstProject.Models;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
       public ViewResult index()
       {
           int hour = DateTime.Now.Hour;
           string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";
           return View ("MyView", viewModel);
       }
    }
}
