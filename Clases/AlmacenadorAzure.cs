using POO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases {
    internal class AlmacenadorAzure : IAlmacenadorArchivos {
        public string Guardar(string archivo) {
            Console.WriteLine("Guardando el archivo en Azure");

            return "URL del archivo";
        }

        public void Borrar(string url) {
            Console.WriteLine("Borrando el archivo en Azure");
        }
    }
}
