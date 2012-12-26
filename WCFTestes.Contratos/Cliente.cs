using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WCFTestes.Contratos
{
    [DataContract] // Framework 3.5 sem SP1
    public class Cliente
    {
        [DataMember]
        public String Nome{ get; set; }

        [DataMember]
        public int Idade{ get; set; }

        [DataMember]
        public string Empresa { get; set; }

        [DataMember]
        public decimal Salario { get; set; }

    }
}
