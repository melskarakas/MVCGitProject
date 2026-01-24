using Microsoft.AspNetCore.Mvc;
using MVCGitProject.Models;
using System.Diagnostics;
namespace MVCGitProject.Controllers
{
        

    #region CustomModelLogin
    public class LoginModel
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    #endregion
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;
        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                List<users> userList = _context.users.ToList();
                users user = userList.FirstOrDefault(u => u.user_name == model.username && u.password == model.password);
                if (user == null)
                {
                    ViewBag.Mesaj = "Kullanıcı adı veya şifre hatalı.";
                    return View(model);
                }else
                {
                    return RedirectToAction("Index", "Home");
                }
            }else
            {
                ViewBag.Mesaj = "Lütfen tüm alanları doldurun.";
                return View(model);
            }
        }
    }

}