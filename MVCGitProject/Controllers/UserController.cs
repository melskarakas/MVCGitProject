using Microsoft.AspNetCore.Mvc;
using MVCGitProject.Models;
using System.Diagnostics;
namespace MVCGitProject.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}