using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab._05.entities
{
    internal class Cine
    {
        public Cine() { }
        public String Codigo { get; set; }
        public String Direccion { get; set; }
        public String Gerente { get; set; }
        public String Propiedad {  get; set; }  
        public double Area { get; set; }
        public int NumeroDeSalas { get; set; }
    }
}
