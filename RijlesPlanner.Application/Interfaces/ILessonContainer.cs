using System;
using System.Collections.Generic;
using RijlesPlanner.Application.Models.Lesson;

namespace RijlesPlanner.Application.Interfaces
{
    public interface ILessonContainer
    {
        public List<Lesson> GetAllLessons();
        public void CreateNewLesson(Lesson lesson);
        public Lesson FindLessonById(string id);
        public void DeleteLesson(string id);
    }
}