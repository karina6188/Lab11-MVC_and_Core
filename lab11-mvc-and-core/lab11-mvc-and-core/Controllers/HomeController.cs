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
        Year year = new Year(fromYear, toYear);
        return RedirectToAction("Results", year);
    }

    public ViewResult Results(Year year)
    {
        return View(year);
    }

    public IActionResult AllYears()
    {
        List<Year> years = new List<Year>
        {
            new Year{FromYear = 2000, ToYear = 2020}
        };

        return View(years);
    }
}
