using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MySchool.WebApp.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class SetupController : Controller
    {
        public IActionResult School()
        {
            return View();
        }

        public IActionResult Exam()
        {
            return View();
        }

        public IActionResult AcademicYear()
        {
            return View();
        }

        public IActionResult Class()
        {
            return View();
        }

        public IActionResult Section()
        {
            return View();
        }
        
    }
}