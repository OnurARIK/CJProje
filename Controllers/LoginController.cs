using CJProje.Models;
using Microsoft.AspNetCore.Mvc;

namespace CJProje.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Login model)
        {
            var admin = new User()
            {
                UserName = "Admin",
                UserPass = "Admin",
                UserRole = "Admin"
            };

            var marka = new User()
            {
                UserName = "Marka",
                UserPass = "Marka",
                UserRole = "Uye",
            };


            if (model.UserName == admin.UserName && model.Password == admin.UserPass)
                return RedirectToAction("Index", "Admin");
            else if (model.UserName == marka.UserName && model.Password == marka.UserName)
                return RedirectToAction("Index", "Home");
            else
                TempData["HataliGiris"] = "Kullanıcı Bulunamadı";

            return View();
        }
    }
}

