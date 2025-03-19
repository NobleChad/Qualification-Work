using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Qualification_Work.Models;

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
}
