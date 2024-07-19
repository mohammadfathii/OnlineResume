using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineResume.Models
{
	public class Skill
	{
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public Rate SkillRate { get; set; } = Rate.Good;


        public int PersonalDataId { get; set; }

        [ForeignKey(nameof(PersonalDataId))]
        public virtual PersonalData PersonalData { get; set; }
    }
}
