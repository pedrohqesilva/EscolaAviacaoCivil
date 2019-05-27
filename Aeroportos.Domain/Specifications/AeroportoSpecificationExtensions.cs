using Aeroportos.Domain.Entities;
using Aeroportos.Domain.Interfaces.Specifications;

namespace Aeroportos.Domain.Specifications
{
    public static class AeroportoSpecificationExtensions
    {
        public static ISpecification<Aeroporto> ComCodigoIcao(this ISpecification<Aeroporto> spec, string codigo)
        {
            spec = spec.And(a => a.CodigoIcao == codigo);
            return spec;
        }

        public static ISpecification<Aeroporto> ComCodigoTipoAeroporto(this ISpecification<Aeroporto> spec, int codigo)
        {
            spec = spec.And(a => a.TipoAeroportoId == codigo);
            return spec;
        }

        public static ISpecification<Aeroporto> NaoExcluido(this ISpecification<Aeroporto> spec)
        {
            spec = spec.And(a => !a.IsExcluido);
            return spec;
        }
    }
}