using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Qualification_Work.Data;
using Qualification_Work.Models;

namespace Qualification_Work.Controllers;

[Authorize]
public class HomeController : Controller
{
    private ApplicationDbContext _context;
    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        _context.Add(new Course { Name = "Math" });
        _context.SaveChanges();
        return View();
    }
    [HttpGet]
    public IActionResult Join()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Join(string courseCode)
    {
        return RedirectToAction("Index");
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(string courseName)
    {
        
        return RedirectToAction("Index");
    }
}
