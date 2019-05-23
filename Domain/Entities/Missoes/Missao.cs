using Domain.Entities.Aeroportos;
using Domain.Entities.Avioes;
using Domain.Entities.Base;
using Domain.Entities.Pilotos;
using System;

namespace Domain.Entities.Missoes
{
    public class Missao : BaseEntity
    {
        public DateTime Data { get; set; }
        public int QtdeHoras { get; set; }
        public int QtdePousos { get; set; }
        public string Observacao { get; set; }
        public int AviaoId { get; set; }
        public Aviao Aviao { get; set; }
        public int AlunoId { get; set; }
        public Piloto Aluno { get; set; }
        public int InstrutorId { get; set; }
        public Piloto Instrutor { get; set; }
        public int AeroportoPartidaId { get; set; }
        public Aeroporto AeroportoPartida { get; set; }
        public int AeroportoDestinoId { get; set; }
        public Aeroporto AeroportoDestino { get; set; }

        private Missao() => Metadata.Create();

        public static Missao Create()
        {
            return new Missao
            {
            };
        }
    }
}