using Data.Contracts;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace VotingSystem.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CandidateController : ControllerBase
	{
		private readonly IRepository<Candidate> _candidateRepository;

		public CandidateController()
		{
			_candidateRepository = new Repository<Candidate>();
		}


		[HttpGet]
        public ActionResult<List<Candidate>> Get()
        {
            var candidates = _candidateRepository.GetAll();
            return candidates;
        }

        [HttpPost]
        public ActionResult<Candidate> Create(Candidate candidate)
        {
            _candidateRepository.Add(candidate);
            return candidate;
        }
    }
}
