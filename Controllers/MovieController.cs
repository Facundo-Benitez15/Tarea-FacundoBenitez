using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tarea_Facundo_Benitez.Models;
using Tarea_Facundo_Benitez.services;

namespace Tarea_Facundo_Benitez.Controllers;

public class MovieController : Controller
{

    public IActionResult Index()
    {
        var model = new List<Movie>();
        model = MovieService.GetAll();
        return View(model);
    }

    public IActionResult Detail(string id)
    {
        var model = MovieService.Get(id);
        return View(model);
    }


}
