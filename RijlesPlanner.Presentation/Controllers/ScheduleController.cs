using Microsoft.AspNetCore.Mvc;

namespace RijlesPlanner.Presentation.Controllers
{
    public class ScheduleController : Controller
    {
        // GET: Schedule/Schedule
        public IActionResult Schedule()
        {
            return View();
        }
    }
}