using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MyStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStore.Conrollers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> _employee = new()
        {
            new Employee { Id = 1, FirstName = "Piter", LastName = "Parker", Description = "Spiderman", Age = 30, Number = "8800553535" },
             new Employee { Id = 2, FirstName = "Vladimir", LastName = "Vlasov", Description = "Programmer", Age = 30, Number = "8800553535" }
        };

        private readonly IConfiguration _Configuration;
        public HomeController (IConfiguration configuration) { _Configuration = configuration; }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SecondAction()
        {
            return Content(_Configuration["Greeting"]);
        }
        public IActionResult Employees()
        {
            return View(_employee);
        }
       public  IActionResult MoreInfo(int id)
        {
            var employee = _employee.FirstOrDefault(employe => employe.Id == id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult BlogSingle()
        {
            return View();
        }
    }
}
