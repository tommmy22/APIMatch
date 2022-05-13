using APIMatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatch.Repositories
{
    public interface IChampionshipRepository
    {
        public void CreateChampionship(Championship championship);
        public void DeleteChampionship(int championshipId);
        public void UpdateChampionship(Championship championship, int championshipId);
        IEnumerable<Championship> GetChampionship();
        Championship GetChampionshipById(int championshipId);
    }
}
