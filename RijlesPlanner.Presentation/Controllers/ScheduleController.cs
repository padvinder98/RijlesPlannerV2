using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using RijlesPlanner.Application.Interfaces;
using RijlesPlanner.Application.Models.Lesson;
using RijlesPlanner.Presentation.ViewModels;
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
            return View();
        }
        
        public JsonResult GetAllLessons()
        {
            var result = _lessonContainer.GetAllLessons();

            var data = new List<LessonViewModel>();

            foreach (var item in result)
            {
                data.Add(new LessonViewModel{ Id = item.Id, Title = item.Title, Description = item.Description, Start = item.StartDate, End = item.EndDate});
            }

            return Json(data);
        }
        
        // POST: Schedule/DeleteLesson()
        [HttpPost]
        public IActionResult DeleteLesson([FromBody]string id)
        {
            if (id == null) return Json(new { success = false, responseText= "Er ging iets mis."});
            
            var result = _lessonContainer.FindLessonById(id);

            if (result == null)
            {
                return Json(new { success = false, responseText= "Er ging iets mis."});
            }
                
            _lessonContainer.DeleteLesson(id);

            return Json(new { success = true, responseText= "De les is verwijderd."});

        }


        // POST: Schedule/AddLesson
        [HttpPost]
        public JsonResult AddLesson(AddLessonViewModel model)
        {
            if (ModelState.IsValid)
            {
                var lesson = new Lesson(model.Title, model.Description, model.StartDate, model.EndDate);
                
                _lessonContainer.CreateNewLesson(lesson);
                
                ModelState.Clear();
                
                return Json(new { success = true, responseText= "De les is gepland."});
            }
            
            return Json(new { success = false, responseText= "Niet alle velden zijn correct ingevuld."});
        }
    }
}