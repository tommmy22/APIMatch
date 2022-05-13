using APIMatch.Dtos.Team;
using APIMatch.Models;
using APIMatch.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatch.Controllers
{
    [ApiController]
    [Route("api/team")]
    public class TeamController : Controller 
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IMapper _mapper;

        public TeamController(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Team>> GetAllTeams()
        {
            return Ok(_mapper.Map<IEnumerable<TeamDto>>(_teamRepository.GetTeam()));
        }

        [HttpPost]
        public ActionResult CreateTeam(CreateTeamDto teamDto)
        {
            Team team = _mapper.Map<Team>(teamDto);

            _teamRepository.CreateTeam(team);

            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteTeam(int TeamId)
        {
            _teamRepository.DeleteTeam(TeamId);
            return NoContent();
        }

        [HttpPut("{TeamId}")]
        public ActionResult UpdateTeam(int TeamId, Team team)
        {
            _teamRepository.UpdateTeam(TeamId , team);
            return NoContent();
        }

        [HttpGet("{TeamId}")]
        public ActionResult GetTeamById(int TeamId)
        {
            _teamRepository.GetTeamById(TeamId);
            return NoContent();
        }
    }
}
