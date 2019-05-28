using Aeroportos.Application.Dtos;
using Aeroportos.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aeroportos.Application.Mappings.DtoToDomain
{
    public class AeroportoProfile : Profile
    {
        public AeroportoProfile()
        {
            CreateMap<AdicionarAeroportoDto, Aeroporto>();
        }
    }
}
