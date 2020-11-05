using System;
using System.ComponentModel.DataAnnotations;

namespace RijlesPlanner.Interface
{
    public class LessonDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public LessonDto(Guid id, string title, string description, DateTime startDate, DateTime endDate)
        {
            Id = id;
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;  
        }
        
        public LessonDto(string title, string description, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}