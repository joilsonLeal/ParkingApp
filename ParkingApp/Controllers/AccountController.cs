﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using AutoMapper;
using Domain;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ParkingApp.Models;

namespace ParkingApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _service;
        private readonly IMapper _mapper;
        public AccountController(IUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel model)
        {
            var user = _service.Login(model.Name, model.Password);


            if (user != null)
            {
                if(!user.IsActive)
                {
                    ModelState.AddModelError("", "Your account is disabled, please contact us.");
                    return View();
                }

                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Role, user.Profile.Name),
                };

                var identity = new ClaimsIdentity(claims, "passkey");

                var userPrincipal = new ClaimsPrincipal(new[] { identity });

                HttpContext.SignInAsync(userPrincipal);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Invalid user/pass");
                return View();
            }
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(UserModel model)
        {
            if(model.Password != model.ConfirmPassword)
            {
                ModelState.AddModelError("", "The two passwords do not match!");
                return View();
            }

            try
            {
                var user = _mapper.Map<User>(model);
                _service.Post(user);

                return RedirectToAction("Login");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Erro ao salvar");
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
