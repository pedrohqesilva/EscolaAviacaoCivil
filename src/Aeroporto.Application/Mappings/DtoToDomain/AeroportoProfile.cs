using Aeroportos.Application.Dtos;
using Aeroportos.Domain.Entities;
using AutoMapper;

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