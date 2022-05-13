using APIMatch.Dtos.Game;
using APIMatch.Dtos.Team;
using APIMatch.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatch.Profiles
{
    public class GameProfile : Profile
    {
        public GameProfile()
        {
            CreateMap<CreateGameDto, Game>();
            CreateMap<Game, GameDto>();
        }
    }
}
