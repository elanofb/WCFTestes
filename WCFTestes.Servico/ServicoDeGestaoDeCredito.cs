using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCFTestes.Contratos;

namespace WCFTestes.Servico
{
    public class ServicoDeGestaoDeCredito : IGestorDeCredito
    {
        #region IGestorDeCredito Members

        public decimal RecuperarQuantidadeDeRecursoDisponivel()
        {
            return 1000.0M;
        }

        public void AnalisarProposta(Proposta proposta)
        {
            //nada por enquanto
        }

        public void EfetivarProposta(Proposta proposta)
        {
            //persiste infos na bd
        }

        public Proposta[] RecuperarPropostas(Status status)
        {
            return null;
        }

        #endregion
    }
}
