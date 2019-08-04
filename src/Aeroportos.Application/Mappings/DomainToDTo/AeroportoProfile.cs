using Aeroportos.Application.Dtos;
using Aeroportos.Domain.Entities;
using AutoMapper;

namespace Aeroportos.Application.Mappings.DomainToDTo
{
    public class AeroportoProfile : Profile
    {
        public AeroportoProfile()
        {
            CreateMap<Aeroporto, AeroportoDto>();
        }
    }
}