using AutoMapper;
using Commander.Core;
using Commander.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Commander.Data.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }
}
