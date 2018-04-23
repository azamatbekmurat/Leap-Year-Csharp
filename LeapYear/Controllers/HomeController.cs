using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LeapYear.Models;
using System;

namespace LeapYear.Controllers
{
  public class HomeController : Controller
  {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpGet("leap-year")]
        public ActionResult Check()
        {
          cLeapYear checkLeapYear = new cLeapYear(Int32.Parse(Request.Form["input-year"]));

          checkLeapYear.IsLeapYear();

          return View("Result");
        }


  }
}
