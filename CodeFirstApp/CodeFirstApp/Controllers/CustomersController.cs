﻿using CodeFirstApp.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CodeFirstApp.Controllers
{
    public class CustomersController : Controller
    {
        private readonly AppDbContext _db; // _ bc private
        public CustomersController(AppDbContext context) // interacting with AppDbContext and fetching data from it
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var Customers = _db.Customers.ToList();
            ViewData["Customers"] = Customers;
            return View();
        }
    }
}
