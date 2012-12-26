﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace WCFTestes.Contratos
{
    [DataContract]
    public class Proposta
    {
        [DataMember]
        public int Numero { get; set; }

        [DataMember]
        public DateTime Data { get; set; }

        [DataMember]
        public Cliente Cliente { get; set; }

        [DataMember]
        public Emprestimo Emprestimo { get; set; }

        [DataMember]
        public Status Status { get; set; }
    }
}
