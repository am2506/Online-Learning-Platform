using System.ComponentModel.DataAnnotations;

namespace Online_Learning_Platform.Models
{
    public class DevData
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Job { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }

        public string College { get; set; }
        public string LinkedinUrl { get; set; }
    }
}
