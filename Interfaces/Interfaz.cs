using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Interfaces {
    internal class Interfaz : IInterfaz, IInterfaz2 {
        public bool miPropiedad1 { get; set; }

        public int miPropiedad2 => 42;

        public void miMetodo1() {
            throw new NotImplementedException();
        }

        public string miMetodo2(int param1) {
            throw new NotImplementedException();
        }

        public void miMetodoSegundaInterfaz() {
            throw new NotImplementedException();
        }
    }
}
