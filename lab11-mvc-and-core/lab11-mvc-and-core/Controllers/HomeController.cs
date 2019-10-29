using Microsoft.AspNetCore.Mvc;
using System;

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
}
