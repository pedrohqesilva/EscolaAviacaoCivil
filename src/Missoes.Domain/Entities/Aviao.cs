﻿using Core.Domain.Entities;
using System;

namespace Missoes.Domain.Entities
{
    public class Aviao : BaseEntity
    {
        public string Matricula { get; private set; }
        public DateTime DataInscricao { get; private set; }
        public string Observacao { get; private set; }
        public int ModeloId { get; private set; }
        public virtual Modelo Modelo { get; private set; }

        public Aviao(string matricula, DateTime dataInscricao, string observacao, int modeloId)
        {
            Matricula = matricula;
            DataInscricao = dataInscricao;
            Observacao = observacao;
            ModeloId = modeloId;
        }

        public Aviao UpdateMatricula(string matricula)
        {
            Matricula = matricula;
            return this;
        }
    }
}