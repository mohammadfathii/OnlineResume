using System.ComponentModel.DataAnnotations;

namespace OnlineResume.Models
{
	public class SoftSkills
	{
		[Key]
		public int Id { get; set; }
        public string Title { get; set; }
    }
}
