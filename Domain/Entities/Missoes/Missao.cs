using Domain.Entities.Aeroportos;
using Domain.Entities.Avioes;
using Domain.Entities.Base;
using Domain.Entities.Pilotos;
using System;

namespace Domain.Entities.Missoes
{
    public class Missao : BaseEntity
    {
        public DateTime Data { get; private set; }
        public int QtdeHoras { get; private set; }
        public int QtdePousos { get; private set; }
        public string Observacao { get; private set; }
        public int AviaoId { get; private set; }
        public Aviao Aviao { get; private set; }
        public int AlunoId { get; private set; }
        public Piloto Aluno { get; private set; }
        public int InstrutorId { get; private set; }
        public Piloto Instrutor { get; private set; }
        public int AeroportoPartidaId { get; private set; }
        public Aeroporto AeroportoPartida { get; private set; }
        public int AeroportoDestinoId { get; private set; }
        public Aeroporto AeroportoDestino { get; private set; }

        private Missao() => Metadata.Create();

        public static Missao Create()
        {
            return new Missao
            {
            };
        }
    }
}