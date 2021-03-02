using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;
using System;
using System.Reflection;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult Madlib(string adjective1, string adjective2, string adjective3, string adjective4, string adjective5, string verb1, string verb2, string noun1, string noun2, string noun3, string noun4)
    {
      MadLibsVariable myLibs = new MadLibsVariable();
      myLibs.Adjective1 = adjective1.ToLower();
      myLibs.Adjective2 = adjective2.ToLower();
      myLibs.Adjective3 = adjective3.ToLower();
      myLibs.Adjective4 = adjective4.ToLower();
      myLibs.Adjective5 = adjective5.ToLower();
      myLibs.Verb1 = verb1;
      myLibs.Verb2 = verb2;
      myLibs.Noun1 = noun1;
      myLibs.Noun2 = noun2;
      myLibs.Noun3 = noun3;
      myLibs.Noun4 = noun4;
      return View(myLibs);
    }
  }
}
