using CarStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Controllers
{
    public class HomeController : Controller
    {
        List<Car> cars = new List<Car>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cars()
        {
            cars.Add(new Car { Name = "LADA", Model = "Vesta седан", Price = 651510 });
            cars.Add(new Car { Name = "LADA", Model = "XRAY Cross", Price = 725310 });
            cars.Add(new Car { Name = "LADA", Model = "GRANTA седан", Price = 459810 });

            ViewBag.Cars = cars;
            return View();
        }

        public ActionResult SportCars()
        {
            cars.Add(new Car { Name = "Mercedes", Model = "Benz A-Класс AMG II (W177) 35 AMG", Price = 4650000 });
            cars.Add(new Car { Name = "Bentley", Model = "Continental Flying Spur", Price = 1600000 });
            cars.Add(new Car { Name = "Porsche", Model = "911 GT2 RS 991", Price = 31000000 });

            ViewBag.Cars = cars;
            return View();
        }
    }
}
