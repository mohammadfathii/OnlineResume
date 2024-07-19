using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineResume.Models
{
	public class SoftSkills
	{
		[Key]
		public int Id { get; set; }
        public string Title { get; set; }

        public int PersonalDataId { get; set; }

        [ForeignKey(nameof(PersonalDataId))]
        public virtual PersonalData PersonalData { get; set; }
    }
}
