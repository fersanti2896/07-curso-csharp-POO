using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace POO {
    internal class ClaseDerivada : Publica {
        void metodoPrueba() {
            PropProtegida = 15;
            PropProtegidaInterna = 16;
        }
    }
}
