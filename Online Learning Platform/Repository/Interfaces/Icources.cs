using Online_Learning_Platform.Models;

namespace Online_Learning_Platform.Repository.Interfaces
{
    public interface Icources
    {
        public List<Category> GetCategories();
        public List<Course> GetCourses();
        public void Insert(Course course);
    }
}
