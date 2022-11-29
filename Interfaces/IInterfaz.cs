using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Interfaces {
    internal interface IInterfaz {
        void miMetodo1();
        string miMetodo2(int param1);
        bool miPropiedad1 { get; set; }
        int miPropiedad2 { get; }
    }
}
