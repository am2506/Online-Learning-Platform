namespace Online_Learning_Platform.Models.ViewModels
{
    public class CourseCategoryViewModel
    {
        // Properties related to Category
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        // Properties related to Course
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        //public decimal Price { get; set; }
        public int CategoryIdForCourse { get; set; } // Foreign Key to Category
        public List<Category> AvailableCategories { get; set; } // List of available categories for dropdown

        // Properties for UI selection
        public IEnumerable<Course> Courses { get; set; } // List of courses for viewing in the UI
        public IEnumerable<Category> Categories { get; set; } // List of categories for viewing in the UI
    
}
}
