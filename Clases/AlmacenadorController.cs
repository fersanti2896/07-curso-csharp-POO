using POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases {
    internal class AlmacenadorController {
        private readonly IAlmacenadorArchivos almacenadorArchivos;

        public AlmacenadorController(IAlmacenadorArchivos almacenadorArchivos) {
            this.almacenadorArchivos = almacenadorArchivos;
        }

        public void GuardarPoster(string poster) {
            almacenadorArchivos.Guardar(poster);
        }

        public void BorrarPoster(string url) { 
            almacenadorArchivos.Borrar(url); 
        }
    }
}
