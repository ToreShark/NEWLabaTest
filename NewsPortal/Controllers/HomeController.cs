using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NewsPortal.Data;
using NewsPortal.Models;

namespace NewsPortal.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _db;
    
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _db = context;
    }

    public IActionResult Index()
    {
        ViewBag.Categories = _db.Categories.ToList();
        ViewBag.Articles = _db.Articles.ToList();
        return View();
    }

    public IActionResult Category(int id)
    {
        Category category = _db.Categories.FirstOrDefault(c => c.Id == id);
        ViewBag.Articles = _db.Articles
            .Where(c => c.CategoryId == id)
            .ToList();
        return View(category);
    }
    public IActionResult Article(int id)
    {
        Article artcile = _db.Articles.FirstOrDefault(c => c.Id == id);
        return View(artcile);
    }public IActionResult Privacy()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}