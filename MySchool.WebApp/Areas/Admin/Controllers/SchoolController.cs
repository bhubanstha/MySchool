﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MySchool.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}