using Football_Academy_ASPMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace Football_Academy_ASPMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext _context)
        {
            _context = _context;
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

       
    }
}
