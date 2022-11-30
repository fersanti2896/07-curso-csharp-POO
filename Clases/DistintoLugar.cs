using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases {
    internal class DistintoLugar {
        private readonly AlmacenadorController almacenadorController;

        public DistintoLugar(AlmacenadorController almacenadorController) {
            this.almacenadorController = almacenadorController;
        }

        public void procesar() {
            almacenadorController.GuardarPoster("Un poster.jog");
        }
    }
}
