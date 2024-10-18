using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Online_Learning_Platform.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        public IFormFile? ImageFile { get; set; }  // To hold the uploaded file

        public string? ImageUrl { get; set; }  // URL to the saved image file

        [Required(ErrorMessage = "Duration is required.")]
        [Range(0.1, double.MaxValue, ErrorMessage = "Duration must be a positive number.")]
        public double Duration { get; set; }

        [Required(ErrorMessage = "Total Lecture count is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "There must be at least 1 lecture.")]
        public int TotalLecture { get; set; }

        [Required(ErrorMessage = "Category selection is required.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Instructor selection is required.")]
        public int InstructorId { get; set; }

        public IEnumerable<SelectListItem>? Categories { get; set; }
        public IEnumerable<SelectListItem>? Instructors { get; set; }
    }
}
