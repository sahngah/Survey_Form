using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;

namespace DojoSurvey.Controllers
{
 public class DojoSurveyController : Controller
 {
  [HttpGet]
  [Route("")]
  public IActionResult Index()
  {
   return View("home");
  }

  [HttpPost]
  [Route("result")]
  public IActionResult result(string name, string location, string language, string comment)
  {
    ViewBag.name = name;
    ViewBag.location = location;
    ViewBag.language = language;
    ViewBag.comment = comment;
      return View();
      
  }
 }
}