using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using user.Models;

namespace user.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<StudentDetails> students = new List<StudentDetails>
            {
                new StudentDetails { Id = 1, Name = "John Doe", Email = "nishant@gmail.com" },
                new StudentDetails { Id = 2, Name = "Jane Doe", Email = "jahndoe@gmail.com" },
                new StudentDetails { Id = 3, Name = "Sam Doe", Email = "sam@gmail.com" }
            };
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentCreateVm studentCreateVm)
        {
            var username = studentCreateVm.Name;
            var email = studentCreateVm.Email;
            var password = studentCreateVm.Password;

            if (!ModelState.IsValid)
            {
                return View(studentCreateVm);
            }
            return RedirectToAction("Index");
        }
    }
}