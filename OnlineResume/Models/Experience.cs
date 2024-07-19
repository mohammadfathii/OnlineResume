using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace OnlineResume.Models
{
	public class Experience
	{
		[Key]
		public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [MaybeNull]
        public int PersonalDataId { get; set; } = 1;

        [ForeignKey(nameof(PersonalDataId))]
        [NotMapped]
        public virtual PersonalData PersonalData { get; set; }
    }
}
