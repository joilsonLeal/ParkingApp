using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IParkingService _service;
        private readonly IMapper _mapper;
        public HomeController(IParkingService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(_service.GetAll());
        }

       
    }
}
