using Microsoft.AspNetCore.Mvc.Rendering;

namespace Online_Learning_Platform.ViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Duration { get; set; }
        public int TotalLecture { get; set; }

        public int CategoryId { get; set; }
        public int InstructorId { get; set; }

        public IEnumerable<SelectListItem>? Categories { get; set; }
        public IEnumerable<SelectListItem>? Instructors { get; set; }
    }

}
