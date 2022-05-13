using APIMatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatch.Repositories
{
    public interface ITeamRepository
    {
        IEnumerable<Team> GetTeam();
        Team GetTeamById(int teamId);
        void CreateTeam(Team team);
        void DeleteTeam(int teamId);
        void UpdateTeam(int teamId, Team team);
    }
}
