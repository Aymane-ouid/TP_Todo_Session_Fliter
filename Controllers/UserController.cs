using Microsoft.AspNetCore.Mvc;
using Todo_SRP_DIP.ViewModels;

namespace Todo_SRP_DIP.Controllers
{
    public class UserController : Controller
    {
        [ServiceFilter(typeof(Todo_SRP_DIP.Filters.ThemeFilter))]
        [ServiceFilter(typeof(Todo_SRP_DIP.Filters.LogFilter))]
        public IActionResult Index()
        {
            ViewBag.Theme = HttpContext.Items["Theme"];
            return View();
        }

        [HttpPost]
        [ServiceFilter(typeof(Todo_SRP_DIP.Filters.LogFilter))]
        public IActionResult Index(LoginVM model)
        {
            if (!ModelState.IsValid)
                return View(model);


            if (model.Username == "admin" && model.Password == "123")
            {
                HttpContext.Session.SetString("UserLogin", model.Username);
                return RedirectToAction("Add", "Todos");
            }

            ViewBag.Error = "Login ou mot de passe incorrect";
            return View(model);
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
