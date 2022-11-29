using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO {
    internal abstract class Vehiculo {
        public string? Marca { get; set; }
        public int AnioCreacion { get; set; }

        public virtual void reversa() {
            Console.WriteLine("Dando reversa la implementación");
        }

        public abstract void sonarClaxon();
    }
}
