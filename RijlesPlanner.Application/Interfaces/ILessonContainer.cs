using System.Collections.Generic;
using RijlesPlanner.Application.Models.Lesson;

namespace RijlesPlanner.Application.Interfaces
{
    public interface ILessonContainer
    {
        public List<Lesson> GetAllLessons();
        public void CreateNewLesson(Lesson lesson);
    }
}