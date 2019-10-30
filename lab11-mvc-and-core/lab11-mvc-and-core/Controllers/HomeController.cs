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
        TimeSelected timeSelected = new TimeSelected(fromYear, toYear);
        return RedirectToAction("Results", timeSelected);
    }

    public ViewResult Results(TimeSelected timeSelected)
    {
        return View(TimePerson.GetPersons(timeSelected));
    }
}
