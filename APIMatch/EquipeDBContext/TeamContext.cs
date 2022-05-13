using APIMatch.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatch.EquipeDBContext
{
    public class TeamContext: IdentityDbContext<User, Role, Guid>
    {
        public TeamContext(DbContextOptions<TeamContext> options) : base(options)
        {

        }
        public DbSet<Championship> Championship { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<Team> Team { get; set; }
    }
}
