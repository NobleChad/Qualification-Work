using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Qualification_Work.Controllers;

[Authorize]
public class HomeController : Controller
{

    public HomeController()
    {
    }

    public IActionResult Index()
    {
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
