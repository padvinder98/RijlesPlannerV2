using System;
using System.Collections.Generic;

namespace RijlesPlanner.Interface.Interfaces.Lesson
{
    public interface ILessonContainerDal
    {
        public List<LessonDto> GetAllLessons();

        public List<LessonDto> GetLessonsByUserId(Guid userId);
        public int CreateNewLesson(LessonDto lessonDto);
    }
}