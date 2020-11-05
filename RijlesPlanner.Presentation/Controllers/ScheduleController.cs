using Microsoft.AspNetCore.Mvc;
using RijlesPlanner.Application.Interfaces;
using RijlesPlanner.Application.Models.Lesson;
using RijlesPlanner.Presentation.ViewModels.ScheduleViewModels;

namespace RijlesPlanner.Presentation.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly ILessonContainer _lessonContainer;

        public ScheduleController(ILessonContainer lessonContainer)
        {
            _lessonContainer = lessonContainer;
        }
        
        // GET: Schedule/Schedule
        [HttpGet]
        public IActionResult Schedule()
        {
            var result = _lessonContainer.GetAllLessons();
            
            return View();
        }
        
        // GET: Schedule/AddLesson
        [HttpGet]
        public IActionResult AddLesson()
        {
            return View();
        }
        
        
        // POST: Schedule/AddLesson
        [HttpPost]
        public IActionResult AddLesson(AddLessonViewModel model)
        {
            if (ModelState.IsValid)
            {
                var lesson = new Lesson(model.Title, model.Description, model.StartDate, model.EndDate);
                
                _lessonContainer.CreateNewLesson(lesson);
                
                ModelState.Clear();
                return View();
            }
            
            return View(model);
        }
    }
}