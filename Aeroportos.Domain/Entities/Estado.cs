﻿using Core.Domain.Entities;

namespace Aeroportos.Domain.Entities
{
    public class Estado : BaseEntity
    {
        #region Properties

        public string Sigla { get; private set; }
        public string Descricao { get; private set; }
        public int PaisId { get; private set; }
        public Pais Pais { get; private set; }

        #endregion Properties

        #region Constructors

        public Estado(string sigla, string descricao, int paisId)
        {
            Sigla = sigla;
            Descricao = descricao;
            PaisId = paisId;
        }

        #endregion Constructors

        #region Update

        public void Update(string sigla, string descricao, int paisId)
        {
            this
                .UpdateSigla(sigla)
                .UpdateDescricao(descricao)
                .UpdatePais(paisId);
        }

        public Estado UpdateSigla(string sigla)
        {
            Sigla = sigla;
            return this;
        }

        public Estado UpdateDescricao(string descricao)
        {
            Descricao = descricao;
            return this;
        }

        public Estado UpdatePais(int paisId)
        {
            PaisId = paisId;
            return this;
        }

        #endregion Update
    }
}