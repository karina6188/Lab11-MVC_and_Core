using lab11_mvc_and_core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for HomeController
/// </summary>
public class HomeController : Controller
{
    [HttpGet]
	public ViewResult Index()
	{
        return View();
	}

    [HttpPost]
    public IActionResult Index(int fromYear, int toYear)
    {
        List<TimePerson> result = TimePerson.GetPersons(fromYear, toYear);
        return RedirectToAction("Results", result);
    }

    public ViewResult Results(TimePerson person)
    {
        return View(person);
    }
}
