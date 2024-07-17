using System.ComponentModel.DataAnnotations;

namespace OnlineResume.Models
{
	public class Experience
	{
		[Key]
		public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
