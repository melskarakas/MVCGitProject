using Microsoft.AspNetCore.Mvc;

namespace MVCGitProject.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
