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
        private readonly IParkingService _service;
        public HomeController(IParkingService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            try
            {
                var a = _service.Get(1);
                var b = _service.GetAll();
            }
            catch (Exception e)
            {

            }
            return View();
        }

    }
}
