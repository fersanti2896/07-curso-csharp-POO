using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO {
    internal class Bicicleta : Vehiculo {
        public Bicicleta(string marca) : base(marca) {
        }

        public override void sonarClaxon() {
            Console.WriteLine("¡Rin Riin!");
        }
    }
}
