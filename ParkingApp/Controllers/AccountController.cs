using System;
using System.Collections.Generic;
using System.Security.Claims;
using Domain;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ParkingApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _service;
        public AccountController(IUserService service)
        {
            _service = service;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User model)
        {
            var user = _service.Login(model.Name, model.Password);

            if (user != null)
            {
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
        public IActionResult SignUp(User model)
        {
            try
            {
                _service.Post(model);

                return RedirectToAction("Login");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Erro ao salvar");
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Secret()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
