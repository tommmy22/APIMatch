using APIMatch.Dtos.Game;
using APIMatch.Models;
using APIMatch.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APIMatch.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/game")]
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;
        private readonly IMapper _mapper;

        public GameController(IGameRepository gameRepository, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Game>> GetGames()
        {
            return Ok(_mapper.Map<IEnumerable<GameDto>>(_gameRepository.GetAllGames()));
        }

        [HttpGet("{gameId}")]
        public ActionResult<Game> GetGameById(int gameId)
        {
            return Ok(_gameRepository.GetGameById(gameId));
        }

        [HttpPost]
        public ActionResult CreateGame(CreateGameDto gameDto)
        {
            Game game = _mapper.Map<Game>(gameDto);

            _gameRepository.CreateGame(game);

            return Ok();
        }

        [HttpDelete("{gameId}")]
        public ActionResult DeleteGame(int gameId)
        {
            Game game = _gameRepository.GetGameById(gameId);

            if(game == null)
            {
                return NotFound();
            }

            _gameRepository.DeleteGame(gameId);

            return NoContent();
        }
    }
}
