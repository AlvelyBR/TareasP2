using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class DocenteFijo : Empleado
    {
        private decimal sueldoBase;
        private bool meta;
        public DocenteFijo(string nombre, string apellido, decimal sueldoBase, bool meta) : base(nombre, apellido)
        {
            this.sueldoBase = sueldoBase;
            this.meta = meta;
        }

        public decimal SueldoBase
        {
            get { return sueldoBase; }

            set { sueldoBase = (value >= 0) ? value : 0; }
        }

        public bool Meta
        {
            get { return meta; }

            set { meta = value; }
        }

        public override decimal Salario()
        {
            if (meta == true)
            {
                sueldoBase = sueldoBase + (sueldoBase * 0.10m);

                return sueldoBase;
            }
            else
            {
                return sueldoBase / 2;
            }
        }
    }
}
