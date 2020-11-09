using System;
using System.Collections.Generic;
using System.Linq;
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

            return result.Select(lessonDto => new Lesson(lessonDto)).ToList();
        }

        public void CreateNewLesson(Lesson lesson)
        {
            _lessonContainerDal.CreateNewLesson(new LessonDto(lesson.Title, lesson.Description, lesson.StartDate, lesson.EndDate));
        }

        public Lesson FindLessonById(string id)
        {
            var lessonDto = _lessonContainerDal.FindLessonById(id);

            return lessonDto == null ? null : new Lesson(lessonDto);
        }

        public void DeleteLesson(string id)
        {
            _lessonContainerDal.DeleteLesson(id);
        }
    }
}