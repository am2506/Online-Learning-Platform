
using Online_Learning_Platform.Models;
namespace Online_Learning_Platform.ModelBL
{
    public class studentsBL
    {
        List<Student> students;
        public studentsBL()
        {
            // students = new List<Student>
            //{
            //    new Student { UserName = "student1", Email = "student1@example.com" },
            //    new Student { UserName = "student2", Email = "student2@example.com" },
            //    new Student { UserName = "student3", Email = "student3@example.com" },
            //    new Student { UserName = "student4", Email = "student4@example.com" },
            //    new Student { UserName = "student5", Email = "student5@example.com" }
            //};


        }
        public List<Student> GetAll()
        {
            return students;
        }
    }

}
