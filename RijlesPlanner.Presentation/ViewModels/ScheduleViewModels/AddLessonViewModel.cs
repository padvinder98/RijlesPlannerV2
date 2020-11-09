using System;
using System.ComponentModel.DataAnnotations;

namespace RijlesPlanner.Presentation.ViewModels.ScheduleViewModels
{
    public class AddLessonViewModel
    {
        [Required]
        [Display(Name = "Titel")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Omschrijving")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Start datum en tijd")]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "Eind datum en tijd")]
        public DateTime EndDate { get; set; }
    }
}