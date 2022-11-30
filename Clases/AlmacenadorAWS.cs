using POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases {
    internal class AlmacenadorAWS : IAlmacenadorArchivos {

        public string Guardar(string archivo) {
            Console.WriteLine("Guardando archivo en AWS");

            return "URL del archivo en AWS";
        }

        public void Borrar(string url) {
            Console.WriteLine("Borrando el archivo en AWS");
        }
    }
}
