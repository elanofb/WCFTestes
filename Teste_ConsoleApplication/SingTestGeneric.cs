using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teste_ConsoleApplication
{
    class SingTestGeneric<T> where T : class
    {
        public static T intance;
        public static object initLock = new object();

        //public static T 
    }
}
