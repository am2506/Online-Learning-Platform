using Online_Learning_Platform.Models;

namespace Online_Learning_Platform.ModelBL
{
    public class InstructorBL
    {
        List<Instructor> instructors;

        public InstructorBL() {
//             instructors = new List<Instructor>
//{
//            new Instructor { UserName = "instructor1", Email = "instructor1@example.com" },
//            new Instructor { UserName = "instructor2", Email = "instructor2@example.com" },
//            new Instructor { UserName = "instructor3", Email = "instructor3@example.com" },
//            new Instructor { UserName = "instructor4", Email = "instructor4@example.com" },
//            new Instructor { UserName = "instructor5", Email = "instructor5@example.com" }
//        };
        }
        

        public List<Instructor> GetAll()
        {
            return instructors;
        }
        //public Instructor GetById(int id)
        //{
        //    var res = instructors.SingleOrDefault(x => x.Id == id);

        //    return res;
        //}
    }
}
