using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO {
    internal class Carro : Vehiculo {
        public void EncenderRadio() {
            Console.WriteLine("¡Encendiendo la radio!");
        }

        public override void sonarClaxon() {
            Console.WriteLine("¡Bip Bip!");
        }
    }
}
