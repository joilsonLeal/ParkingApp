using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParkingApp.Models;

namespace ParkingApp.Controllers
{
    public class ParkingController : Controller
    {
        private readonly IParkingService _service;
        private readonly IMapper _mapper;
        private readonly ICountryService _countryService;

        public ParkingController(IParkingService service, IMapper mapper, ICountryService countryService)
        {
            _service = service;
            _mapper = mapper;
            _countryService = countryService;
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

        [HttpGet]
        public IActionResult Edit(int id = 0, string message = null)
        {
            ParkingViewModel model = new ParkingViewModel();
            model.Countries = _mapper.Map<List<CountryModel>>(_countryService.GetAll());

            if(message != null)
            {
                ModelState.AddModelError("", "An error occurred while saving");
            }

            if (id > 0)
            {
                model.Parking = _mapper.Map<ParkingModel>(_service.Get(id));
                return View(model);
            }

            model.Parking = new ParkingModel();
            return View(model);
        }


        [Authorize]
        [HttpPost]
        public IActionResult Edit(ParkingViewModel model)
        {
            var parking = _mapper.Map<Parking>(model.Parking);

            try
            {
                _service.Save(parking);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Edit", new { id = model.Parking.Id, message = "An error occurred while saving" });
            }

        }
    }
}
