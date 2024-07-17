using System.ComponentModel.DataAnnotations;

namespace OnlineResume.Models
{
	public class Language
	{
		[Key]
		public int Id { get; set; }
        public string Name { get; set; }
        public Rate SkillRate { get; set; }
    }
}
