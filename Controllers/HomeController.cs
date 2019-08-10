using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using validatingFormSubmission.Models;

namespace validatingFormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("Check")]

        public IActionResult Check(User newUser)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success", newUser);
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("Success")]
        public IActionResult Success(User newUser)
        {
            return View("Success", newUser);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
