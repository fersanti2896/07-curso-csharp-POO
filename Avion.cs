using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO {
    internal class Avion : Vehiculo {
        public Avion(string marca) : base(marca) {
        }

        public override void sonarClaxon() {
            Console.WriteLine("¡!");
        }
    }
}
