using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;
using Microsoft.AspNetCore.Http;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.errors = new List<string>();
            return View();
        }

        [HttpPost]
        [Route("submit")]
        public IActionResult Success(string firstName, string lastName, int age, string email, string password)
        {
            User NewUser = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Email = email,
                Password = password
            };

            TryValidateModel(NewUser);
            return View("Success");
            
        }

    }
}
