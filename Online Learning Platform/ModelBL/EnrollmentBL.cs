using Online_Learning_Platform.Models;
using Online_Learning_Platform.Repository.Interfaces;

namespace Online_Learning_Platform.ModelBL
{
    public class EnrollmentBL
    {
        List<Enrollment> Enrollmentes;
        public EnrollmentBL() {
            //Enrollmentes = new List<Enrollment>
            //{
            //    new Enrollment { CourseId = 1, StudentId = 1, Prograss = 50, EnrollmentDate = DateTime.Now },
            //    new Enrollment { CourseId = 1, StudentId = 2, Prograss = 70, EnrollmentDate = DateTime.Now },
            //    new Enrollment { CourseId = 2, StudentId = 3, Prograss = 80, EnrollmentDate = DateTime.Now },
            //    new Enrollment { CourseId = 2, StudentId = 4, Prograss = 90, EnrollmentDate = DateTime.Now },
            //    new Enrollment { CourseId = 3, StudentId = 5, Prograss = 60, EnrollmentDate = DateTime.Now }
            //};

        }
        public List<Enrollment> GetAll()
        {
            return Enrollmentes;
        }
        public Enrollment GetById(int id)
        {
            var res = Enrollmentes.SingleOrDefault(x => x.Id == id);

            return res;
        }
    }
}
