using InfoSystem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InfoSystem.Controllers
{
    public class AccountController : Controller
    {

        private readonly AppDbContext _dbContext;

        public AccountController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var employee = _dbContext.Employees.FirstOrDefault(e => e.Email == email && e.Password == password);

            if (employee != null)
            {
                HttpContext.Session.SetString("UserRole", employee.Role);
                HttpContext.Session.SetString("UserName", employee.Name);
                return RedirectToAction("Index", "Home"); 
            }

            ModelState.AddModelError("", "Ogiltig inloggning."); 
            return View(); 
        }

        public IActionResult Logout()
        {
            
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }
    }
}

