using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ParkingApp.Models;

namespace ParkingApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly ParkingAppContext _context;

        public HomeController(ParkingAppContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {
                var a = _context.Users.ToList();
            }
            catch (Exception e)
            {

                throw;
            }
            return View();
        }

    }
}
