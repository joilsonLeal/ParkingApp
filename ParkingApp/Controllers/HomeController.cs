using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Data.Context;
using Data.Repository;
using Domain;
using Domain.Entities;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ParkingApp.Models;
using Service.Services;

namespace ParkingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _service;
        public HomeController(IUserService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
