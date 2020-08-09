using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace ParkingApp.Controllers
{
    public class ParkingController : Controller
    {
        private readonly IParkingService _service;

        public ParkingController(IParkingService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(_service.Get(id));
        }

        public IActionResult Edit(int id = 0)
        {
            if(id > 0)
            {
                return View(_service.Get(id));
            }
            return View();
        }
    }
}
