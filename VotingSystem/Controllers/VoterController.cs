using Data.Contracts;
using Data.Repositories;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace VotingSystem.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class VoterController : ControllerBase
	{
		private readonly IRepository<Voter> _votersRepository;

		public VoterController()
		{
			_votersRepository = new VoterRepository();
		}


		[HttpGet]
		public ActionResult<List<Voter>> Get()
		{
			var voters = _votersRepository.GetAll();
			return voters;
		}

		[HttpPost]
		public ActionResult<Voter> Create(Voter voter)
		{
			_votersRepository.Add(voter);
			return voter;
		}
	}
}
