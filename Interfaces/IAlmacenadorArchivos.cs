using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Interfaces {
    internal interface IAlmacenadorArchivos {
        string Guardar(string archivo);
        void Borrar(string url);
    }
}
