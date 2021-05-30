using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Conrollers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _Configuration;
        public HomeController (IConfiguration configuration) { _Configuration = configuration; }
        public IActionResult Index()
        {
            return Content("Hello from my Control");
        }
        public IActionResult SecondAction()
        {
            return Content(_Configuration["Greeting"]);
        }
    }
}
