using System.ComponentModel.DataAnnotations;

namespace Entities
{
	public class Candidate : IEntity
	{
		public Candidate()
		{
			Voters = new List<Voter>();
		}

		public int Id { get; set; }

		[Required]
		public string FullName { get; set; }

		public int VoteCounts
		{
			get { return Voters.Count; }
		}

		public List<Voter> Voters { get; set; }
	}
}
