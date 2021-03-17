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
                UserName = "admin",
                UserPass = "admin",
                UserRole = "admin"
            };

            var marka = new User()
            {
                UserName = "adidas",
                UserPass = "adidas",
                UserRole = "Uye",
            };
            var marka2 = new User()
            {
                UserName = "nike",
                UserPass = "nike",
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

