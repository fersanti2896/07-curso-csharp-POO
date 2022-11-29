using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO {
    internal class Camion : Vehiculo {
        public override void reversa() {
            base.reversa();
            Console.WriteLine("¡Beep! ¡Beep! ¡Beep!");
        }
    }
}