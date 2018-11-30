using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers
{
  public class HomeController: Controller
    {
        //routes
        // localhost:5000
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
          var Languages = new List<string>{"C#","JAVA","PYTHON","JAVASCRIPT"};
          var Locations = new List<string>{"SEATTLE","NEW YORK"};
          ViewBag.languages = Languages;
          ViewBag.locations =  Locations;
          return View("index");
        }

        // localhost:5000/result
        [HttpGet]
        [Route("result")]
        public IActionResult result(string name, string location, string language, string comment)
        {
          ViewBag.name = name;
          ViewBag.location = location;
          ViewBag.language = language;
          ViewBag.comment = comment;
          return View();
        }

        // localhost:5000/submitform
        [HttpPost]
        [Route("SubmitForm")]
        public IActionResult SubmitForm(string name, string location, string language, string comment)
        {
          return RedirectToAction("result", new {Name = name, Location = location, Language = language, Comment = comment});
        }
    }
}