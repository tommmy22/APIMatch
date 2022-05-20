using APIMatch.EquipeDBContext;
using APIMatch.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatch.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly TeamContext _context;

        public GameRepository(TeamContext context)
        {
            _context = context;
        }

        public IEnumerable<Game> GetGameByChampionshipId(int championshipId)
        {
            return _context.Game.Where(g => g.ChampionshipId == championshipId).ToList();
        }

        public IEnumerable<Game> GetAllGames()
        {
            return _context.Game
                .Include(g => g.HomeTeam).ThenInclude(ht => ht.Championship)
                .Include(g => g.ExtTeam).ThenInclude(et => et.Championship)
                .ToList();
        }

        public Game GetGameById(int gameId)
        {
            return _context.Game.Find(gameId);
        }

        public void DeleteGame(int gameId)
        {
            Game game = _context.Game.Find(gameId);

            _context.Game.Remove(game);

            _context.SaveChanges();
        }

        public Game CreateGame(Game game)
        {
            _context.Game.Add(game);

            _context.SaveChanges();

            return game;
        }
    }
}
