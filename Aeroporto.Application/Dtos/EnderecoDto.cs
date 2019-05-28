﻿using Aeroportos.Application.Dtos.Base;

namespace Aeroportos.Application.Dtos
{
    public class EnderecoDto : BaseEntityDto
    {
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public CidadeDto Cidade { get; set; }
    }
}