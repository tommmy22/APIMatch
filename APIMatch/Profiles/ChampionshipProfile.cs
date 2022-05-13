using APIMatch.Dtos.Championship;
using APIMatch.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMatch.Profiles
{
    public class ChampionshipProfile : Profile
    {
        public ChampionshipProfile()
        {
            CreateMap<CreateChampionshipDto, Championship>();
        }
    }
}
