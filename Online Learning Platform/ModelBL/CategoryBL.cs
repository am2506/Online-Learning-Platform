
using Online_Learning_Platform.Models;

namespace Online_Learning_Platform.ModelBL
{
    public class CategoryBL
    {
        List<Category> categories;
        public CategoryBL() {
            // categories = new List<Category>
            //{
            //    new Category { Name = "Programming" },
            //    new Category { Name = "Databases" },
            //    new Category { Name = "Frontend" },
            //    new Category { Name = "Backend" },
            //    new Category { Name = "DevOps" }
            //};
        }
        public List<Category>  GetAll()
        {
            return categories;
        }

    }
}
