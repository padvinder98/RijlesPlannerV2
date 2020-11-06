using System;

namespace RijlesPlanner.Presentation.ViewModels
{
    public class LessonViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}