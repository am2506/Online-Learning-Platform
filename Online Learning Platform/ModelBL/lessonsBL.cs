using Online_Learning_Platform.Models;

namespace Online_Learning_Platform.ModelBL
{
    public class lessonsBL
    {
        List<Lesson> lessons;
        public lessonsBL()
        {
            // lessons = new List<Lesson>
            //{
            //    new Lesson { CourseId = 1, VideoUrl = "https://example.com/video1" },
            //    new Lesson { CourseId = 1, VideoUrl = "https://example.com/video2" },
            //    new Lesson { CourseId = 2, VideoUrl = "https://example.com/video3" },
            //    new Lesson { CourseId = 3, VideoUrl = "https://example.com/video4" },
            //    new Lesson { CourseId = 4, VideoUrl = "https://example.com/video5" }
            //};
        }
        public List<Lesson> GetAll()
        {
            return lessons;
        }
        public Lesson GetById(int id)
        {
            var res=lessons.SingleOrDefault(l => l.Id == id);
            return res;
        }

    }
}
