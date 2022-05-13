using APIMatch.EquipeDBContext;
using APIMatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatch.Repositories
{
    public class ChampionshipRepository : IChampionshipRepository 
    {
        public readonly TeamContext _context;
        public ChampionshipRepository(TeamContext context)
        {
            _context = context ; 
        }

        public void CreateChampionship(Championship championship)
        {
            _context.Championship.Add(championship);

            _context.SaveChanges();
        }

        public void DeleteChampionship(int championshipId)
        {
            Championship championship = _context.Championship.Find(championshipId);

            _context.Championship.Remove(championship);

            _context.SaveChanges();
        }

        public void UpdateChampionship(Championship championship, int championshipId)
        {
            Championship championshipEntity = _context.Championship.Find(championshipId);
            championshipEntity.Name = championship.Name;

            _context.Update(championshipEntity);
            _context.SaveChanges();
        }

        public IEnumerable<Championship> GetChampionship()
        {
            return _context.Championship.ToList();
        }

        public Championship GetChampionshipById(int championshipId)
        {
            return _context.Championship.Find(championshipId);
        }
    }
}
