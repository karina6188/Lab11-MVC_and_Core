using lab11_mvc_and_core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

public class HomeController : Controller
{
    /// <summary>
    /// Set the View to show the index page as a default page.
    /// </summary>
    [HttpGet]
    public ViewResult Index()
    {
        return View();
    }

    /// <summary>
    /// This function redirects the Results function that shows Results page.
    /// </summary>
    [HttpPost]
    public IActionResult Index(int fromYear, int toYear)
    {
        TimeSelected timeSelected = new TimeSelected(fromYear, toYear);
        return RedirectToAction("Results", timeSelected);
    }

    /// <summary>
    /// This function show the data of selected people to View, which appears on the Results.cshtml.
    /// </summary>
    public ViewResult Results(TimeSelected timeSelected)
    {
        return View(TimePerson.GetPersons(timeSelected));
    }
}
