using Aeroportos.Application.Dtos;
using Aeroportos.Domain.Entities;
using AutoMapper;

namespace Aeroportos.Application.Mappings.DomainToDTo
{
    public class AeroportoProfile : Profile
    {
        public AeroportoProfile()
        {
            CreateMap<Aeroporto, AeroportoDto>()
                .ForMember(dest => dest.Guid, opt => opt.MapFrom(src => src.Guid))
                .ForMember(dest => dest.CodigoIcao, opt => opt.MapFrom(src => src.CodigoIcao))
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.Descricao))
                .ForMember(dest => dest.TipoAeroporto, opt => opt.MapFrom(src => new TipoAeroportoDto
                {
                    Sigla = src.TipoAeroporto.Sigla,
                    Descricao = src.TipoAeroporto.Descricao
                }))
                .ForMember(dest => dest.Endereco, opt => opt.MapFrom(src => new EnderecoDto
                {
                    Cep = src.Endereco.Cep,
                    Logradouro = src.Endereco.Logradouro,
                    Numero = src.Endereco.Numero,
                    Complemento = src.Endereco.Complemento,
                    Bairro = src.Endereco.Bairro,
                    Cidade = new CidadeDto
                    {
                        Sigla = src.Endereco.Cidade.Sigla,
                        Descricao = src.Endereco.Cidade.Descricao,
                        Estado = new EstadoDto
                        {
                            Sigla = src.Endereco.Cidade.Estado.Sigla,
                            Descricao = src.Endereco.Cidade.Estado.Descricao,
                            Pais = new PaisDto
                            {
                                Sigla = src.Endereco.Cidade.Estado.Pais.Sigla,
                                Descricao = src.Endereco.Cidade.Estado.Pais.Descricao
                            }
                        }
                    }
                }));
        }
    }
}
