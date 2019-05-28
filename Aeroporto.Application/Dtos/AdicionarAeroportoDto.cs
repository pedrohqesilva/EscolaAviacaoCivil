using Aeroportos.Application.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aeroportos.Application.Dtos
{
    public class AdicionarAeroportoDto
    {
        public string CodigoIcao { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int EnderecoId { get; set; }
        public int TipoAeroportoId { get; set; }
    }
}
