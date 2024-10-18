using LeaveManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Controllers;

public class TestController : Controller
{
    // GET
    public IActionResult Index()
    {
        var data = new TestViewModel
        {
            Name = "Johan",
            DateOfBirth = new DateTime(1981,05,23),
        };
        
        return View(data);
    }
}