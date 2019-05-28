using Core.Domain.Entities;
using System;

namespace Avioes.Domain.Entities
{
    public class Aviao : BaseEntity
    {
        #region Properties

        public string Matricula { get; private set; }
        public DateTime DataInscricao { get; private set; }
        public string Observacao { get; private set; }
        public int ModeloId { get; private set; }
        public virtual Modelo Modelo { get; private set; }

        #endregion Properties

        #region Constructors

        public Aviao(string matricula, DateTime dataInscricao, string observacao, int modeloId)
        {
            Matricula = matricula;
            DataInscricao = dataInscricao;
            Observacao = observacao;
            ModeloId = modeloId;
        }

        #endregion Constructors

        #region Update

        public void Update(string matricula, DateTime dataInscricao, string observacao)
        {
            UpdateMatricula(matricula)
            .UpdateDataInscricao(dataInscricao)
            .UpdateObservacao(observacao);
        }

        public Aviao UpdateMatricula(string matricula)
        {
            Matricula = matricula;
            return this;
        }

        public Aviao UpdateDataInscricao(DateTime dataInscricao)
        {
            DataInscricao = dataInscricao;
            return this;
        }

        public Aviao UpdateObservacao(string observacao)
        {
            Observacao = observacao;
            return this;
        }

        public Aviao UpdateModelo(int modeloId)
        {
            ModeloId = modeloId;
            return this;
        }

        #endregion Update
    }
}