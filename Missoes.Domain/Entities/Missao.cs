using Core.Domain.Entities;
using System;

namespace Missoes.Domain.Entities
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
    }
}