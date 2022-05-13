using APIMatch.Dtos.Team;
using APIMatch.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatch.Profiles
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<CreateTeamDto, Team>();
            CreateMap<Team, TeamDto>()
                .ForMember(dest => dest.ChampionshipName, opt => opt.MapFrom(src => src.Championship.Name));
        }
    }
}
