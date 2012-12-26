using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WCFTestes.Contratos
{
    [DataContract]
    public class Emprestimo
    {
        [DataMember]
        public int Valor { get; set; }

        [DataMember]
        public int QuantidadeDeParcelas { get; set; }

        [DataMember]
        public decimal TaxaDeJuros{ get; set; }
    }
}
