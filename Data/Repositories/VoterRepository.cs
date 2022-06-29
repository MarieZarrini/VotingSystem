using Data.Contracts;
using Entities;

namespace Data.Repositories
{
	public class VoterRepository : Repository<Voter>
	{
		private readonly IRepository<Candidate> _candidateRepository;

		public VoterRepository()
		{
			_candidateRepository = new Repository<Candidate>();
		}


		public override void Add(Voter voter)
		{
			base.Add(voter);
			UpdateCandidateVoters(voter);
		}


		private void UpdateCandidateVoters(Voter voter)
		{
			var candidate = _candidateRepository.GetById(voter.CandidateId);
			candidate.Voters.Add(voter);
		}
	}
}
