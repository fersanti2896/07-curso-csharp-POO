using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Record {
    internal record Persona : Humano {
        public int Edad { get; set; }
    }
}
