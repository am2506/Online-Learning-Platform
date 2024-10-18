namespace Online_Learning_Platform.Models.ViewModels
{
    public class DashboardViewModel
    {
       
        public int TotalUsers { get; set; }
        public int TotalCourses { get; set; }
        public int TotalEnrollments { get; set; }
        public int TotalCategories { get; set; }

        
        public List<string> UserRoles { get; set; }
        public List<int> RoleCounts { get; set; } 

        
        public List<string> Categories { get; set; } 
        public List<int> CategoryCounts { get; set; } 

        public List<string> CourseTitles { get; set; } 
        public List<int> CourseEnrollmentCounts { get; set; } 

        public List<string> CategoryNames { get; set; } 
        public List<int> CategoryCourseCounts { get; set; } 

        public List<string> EnrollmentDates { get; set; } 
        public List<int> DailyEnrollments { get; set; } 
    }
}
