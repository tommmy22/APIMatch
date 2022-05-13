using APIMatch.Dtos.Championship;
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
    [Route("api/championship")]
    public class ChampionshipController : Controller
    {
        private readonly IChampionshipRepository _championshipRepository;
        private readonly IMapper _mapper;

        public ChampionshipController(IChampionshipRepository championshipRepository, IMapper mapper)
        {
            _championshipRepository = championshipRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Championship>> GetAllChampionships()
        {
            return Ok(_championshipRepository.GetChampionship());
        }

        [HttpPost]
        public ActionResult CreateChampionship(CreateChampionshipDto championshipDto)
        {
            Championship championship = _mapper.Map<Championship>(championshipDto);

            _championshipRepository.CreateChampionship(championship);

            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteChampionship(int ChampionshipId)
        {
            _championshipRepository.DeleteChampionship(ChampionshipId);
            return NoContent();
        }

        [HttpPut("{ChampionshipId}")]
        public ActionResult UpdateChampionship(Championship championship, int ChampionshipId)
        {
            _championshipRepository.UpdateChampionship(championship, ChampionshipId);
            return NoContent();
        }

        [HttpGet("{ChampionshipId}")]
        public ActionResult GetChampionshipById(int ChampionshipId)
        {
            _championshipRepository.GetChampionshipById(ChampionshipId);
            return NoContent();
        }
    }
}
