using System.ComponentModel.DataAnnotations;

namespace OnlineResume.Models
{
	public class Project
	{
		[Key]
		public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}
