using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Garcia_ancheta.Models;

namespace Garcia_ancheta.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


    public IActionResult Student()
    {

        StudentPageViewModel resp = new StudentPageViewModel();

        using (var db = new StudInfoSysContext())
        {
            resp.Stud = db.Students.ToList();
        }
        return View(resp);
    }
    public IActionResult Course()
    {
        return View();
    }
    public IActionResult Section()
    {
        return View();
    }
    public IActionResult Room()
    {
        RoomPageViewModel resp = new RoomPageViewModel();
        using(var db = new StudInfoSysContext())
        {
            resp.Rooms = db.Rooms.ToList();
        }
        return View(resp);
    }
    public IActionResult Teacher()
    {
        TeacherPageViewModel resp = new TeacherPageViewModel ();

        using (var db = new StudInfoSysContext())
        {
            resp.teac = db.Teachers.ToList();
        }
        return View(resp);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
