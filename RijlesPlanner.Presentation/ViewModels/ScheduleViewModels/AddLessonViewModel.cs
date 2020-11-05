using System;
using System.ComponentModel.DataAnnotations;

namespace RijlesPlanner.Presentation.ViewModels.ScheduleViewModels
{
    public class AddLessonViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }
    }
}