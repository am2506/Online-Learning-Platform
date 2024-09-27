using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Online_Learning_Platform.Models
{
	public class Course : BaseEntity
	{
		
		public string Title { get; set; }
		public string ? Description { get; set; }
		[ValidateNever]
		public string? ImageUrl { get; set; }
        

        [NotMapped]
        [DisplayName("Image")]
        [ValidateNever]
        public IFormFile ImageFile { get; set; }

        public double Duration { get; set; }
		public int TotalLecture { get; set; }
		//Foreign Key
		public int CategoryId { get; set; }	
		public int InstructorId { get; set; }

        //Navigation Property
        [ValidateNever]
        public ICollection<Lesson> Lessons { get; set; }
        [ValidateNever]
        public Instructor Instructor { get; set; }
        [ValidateNever]
        public Category Category { get; set; }
		[ValidateNever]
		public ICollection<Enrollment> Enrollments { get; set; }

	}
}
