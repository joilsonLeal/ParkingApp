using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParkingApp.Models;

namespace ParkingApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly IUserService _service;
        private readonly IMapper _mapper;

        public UserController(IUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var result = _mapper.Map<List<UserModel>>(_service.GetAll());
            return View(result);
        }

        public ActionResult Edit(int id)
        {
            var result = _mapper.Map<UserModel>(_service.Get(id));
            return View(result);
        }
        [HttpPost]
        public ActionResult Edit(UserModel model)
        {
            try
            {
                var user = _mapper.Map<User>(model);
                _service.Put(user);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "An error occurred while saving");
                return View();
            }
        }
    }
}
