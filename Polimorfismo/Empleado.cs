using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
     public abstract class Empleado
    {
        public string nombre {  get; set; }
        public string apellido {  get; set; }

        public Empleado(string nombre, string apellido) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        

        public abstract decimal Salario();

    }
}
