using APIMatch.EquipeDBContext;
using APIMatch.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatch.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        public readonly TeamContext _context;
        public TeamRepository(TeamContext context)
        {
            _context = context;
        }

        public void CreateTeam(Team team)
        {
            _context.Team.Add(team);

            _context.SaveChanges();
        }

        public IEnumerable<Team> GetTeam()
        {
            return _context.Team.Include(t => t.Championship).ToList();
        }
        
        public void DeleteTeam (int teamId)
        {
            Team team = _context.Team.Find(teamId);
            
            _context.Team.Remove(team);

            _context.SaveChanges();
        }

        public void UpdateTeam (int teamId, Team team)
        {
            Team teamEntity = _context.Team.Find(teamId);
            teamEntity.Name = team.Name;

            _context.Update(teamEntity);
            _context.SaveChanges();
        }

        public Team GetTeamById(int teamId)
        {
            return _context.Team.Find(teamId);
        }

        Team ITeamRepository.GetTeamById(int teamId)
        {
            throw new NotImplementedException();
        }
    }
}
