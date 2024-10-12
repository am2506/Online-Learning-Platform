using System.ComponentModel.DataAnnotations.Schema;

namespace Online_Learning_Platform.Models
{
	[NotMapped]
	public class Email
	{
		public string To { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
	}
}
