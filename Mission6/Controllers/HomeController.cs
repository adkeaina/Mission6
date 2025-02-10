using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6.Models;

namespace Mission6.Controllers;

public class HomeController : Controller
{
    private MoviesAppContext _context;
    public HomeController(MoviesAppContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetToKnowJoel()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult AddNewMovie()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddNewMovie(Movie response)
    {
        _context.Movies.Add(response);
        _context.SaveChanges();
        return View("Confirmation", response);
    }

}