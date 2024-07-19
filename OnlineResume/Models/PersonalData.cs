using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace OnlineResume.Models
{
	public class PersonalData
	{
		[Key]
		public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AboutMe { get; set; }
        public Gender Gender { get; set; } = Gender.Male;

        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<Language> Languages { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<SoftSkills> SoftSkills { get; set; }
	}
}
