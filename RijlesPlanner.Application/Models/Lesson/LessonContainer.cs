using System;
using System.Collections.Generic;
using RijlesPlanner.Application.Interfaces;
using RijlesPlanner.Interface;
using RijlesPlanner.Interface.Interfaces.Lesson;

namespace RijlesPlanner.Application.Models.Lesson
{
    public class LessonContainer : ILessonContainer
    {
        private readonly ILessonContainerDal _lessonContainerDal;

        public LessonContainer(ILessonContainerDal lessonContainerDal)
        {
            _lessonContainerDal = lessonContainerDal;
        }
        
        public List<Lesson> GetAllLessons()
        {
            var result = _lessonContainerDal.GetAllLessons();
            
            var lessons = new List<Lesson>();

            foreach (var lessonDto in result)
            {
                lessons.Add( new Lesson(lessonDto));
            }

            return lessons;
        }

        public void CreateNewLesson(Lesson lesson)
        {
            _lessonContainerDal.CreateNewLesson(new LessonDto(lesson.Title, lesson.Description, lesson.StartDate, lesson.EndDate));
        }
    }
}