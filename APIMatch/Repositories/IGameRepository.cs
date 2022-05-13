using APIMatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatch.Repositories
{
    public interface IGameRepository
    {
        IEnumerable<Game> GetAllGames();
        Game CreateGame(Game game);
        Game GetGameById(int gameId);
        void DeleteGame(int gameId);
    }
}
