using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using ParkingApp.Models;

namespace ParkingApp.Controllers
{
    public class ParkingController : Controller
    {
        private readonly IParkingService _service;
        private readonly IMapper _mapper;

        public ParkingController(IParkingService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var result = _mapper.Map<List<ParkingModel>>(_service.GetAll());
            return View(result);
        }

        public IActionResult Details(int id)
        {
            var result = _mapper.Map<ParkingModel>(_service.Get(id));
            return View(result);
        }

        public IActionResult Edit(int id = 0)
        {
            if(id > 0)
            {
                var result = _mapper.Map<ParkingModel>(_service.Get(id));
                return View(result);
            }
            return View();
        }

        [HttpDelete]
        public IActionResult Delete(int id = 0)
        {
            return View("Index");
        }
    }
}
