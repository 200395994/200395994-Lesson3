using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _200395994_Lesson3.Models;

namespace _200395994_Lesson3.Controllers
{
    public class CarsController : Controller
    {

        List<Car> carList = new List<Car>()
        {
            new Car {Id = 1, Brand = "Audi", Model = "720", Type = "Dashing", Year = 2018 },
            new Car {Id = 2, Brand = "MUstang", Model = "300", Type = "luxury", Year = 2015 },
            new Car {Id = 3, Brand = "Hyndyuai", Model = "ACCCCC", Type = "classic", Year = 2009 }
        };
        // GET: Cars
        public ActionResult Index()
        {
            return View(carList);
        }


        //GET: Cars/Details - Single car
        public ActionResult Details(int? id)
        {
            if (id == null || id > carList.Count)
            {
                return Content("Invalid car id");
            }
            var ind = Convert.ToInt32(id) - 1;
            var car = carList[ind];

            return View(car);
        }
    }
    }