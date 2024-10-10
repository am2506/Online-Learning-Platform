using Online_Learning_Platform.Models;

namespace Online_Learning_Platform.ModelBL
{
    public class UserBaseBL
    {
        List<UserBase> users;
        public UserBaseBL() {
//             users = new List<UserBase>
//{
//            new UserBase { UserName = "admin1", Email = "admin1@example.com" },
//            new UserBase { UserName = "instructor1", Email = "instructor1@example.com" },
//            new UserBase { UserName = "student1", Email = "student1@example.com" },
//            new UserBase { UserName = "student2", Email = "student2@example.com" },
//            new UserBase { UserName = "instructor2", Email = "instructor2@example.com" }
//        };
        }
        public List<UserBase> GetAll()
        {
            return users;
        }
        //public UserBase GetById(int id)
        //{
        //    var res = users.SingleOrDefault(x => x.Id == id);

        //    return res;
        //}
    }
}
