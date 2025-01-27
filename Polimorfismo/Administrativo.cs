using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Administrativo : DocenteFijo
    {
        private string puesto;
        public Administrativo(string nombre, string apellido, decimal sueldoBase, bool meta, string puesto) : base(nombre, apellido, sueldoBase, meta) 
        {
        this.puesto = puesto;
        }

        public string Puesto
        {
            get { return puesto; }

            set { puesto = value; }
        }
        public override decimal Salario()
        {
            return base.Salario();
        }

    }
}
