using System.ComponentModel.DataAnnotations;

namespace Entities
{
	public class Voter : IEntity
	{
		public int Id { get; set; }

		[Required]
		public string FullName { get; set; }

		[Required]
		public int CandidateId { get; set; }
	}
}
