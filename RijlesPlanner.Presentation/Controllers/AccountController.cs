using Microsoft.AspNetCore.Mvc;
using RijlesPlanner.Application.Interfaces;
using RijlesPlanner.Presentation.ViewModels.AccountViewModels;

namespace RijlesPlanner.Presentation.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILessonContainer _lessonContainer;
        
        public AccountController(ILessonContainer lessonContainer)
        {
            _lessonContainer = lessonContainer;
        }
        
        // GET: Account/Register
        [HttpGet]
        public IActionResult Register()
        {
            _lessonContainer.GetAllLessons();
            return View();
        }
        
        // POST: Account/Register
        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            
            return View(model);
        }
        
        // GET: Account/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        
        // POST: Account/Login
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            
            return View();
        }
    }
}