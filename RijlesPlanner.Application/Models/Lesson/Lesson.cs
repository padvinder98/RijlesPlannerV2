using System;
using RijlesPlanner.Interface;

namespace RijlesPlanner.Application.Models.Lesson
{
    public class Lesson
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public Lesson(LessonDto lessonDto)
        {
            this.Id = lessonDto.Id;
            this.Title = lessonDto.Title;
            this.Description = lessonDto.Description;
            this.StartDate = lessonDto.StartDate;
            this.EndDate = lessonDto.EndDate;
        }

        public Lesson(string title, string description, DateTime startDate, DateTime endDate)
        {
            this.Title = title;
            this.Description = description;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}