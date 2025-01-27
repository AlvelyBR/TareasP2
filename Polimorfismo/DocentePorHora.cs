using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class DocentePorHora : Empleado
    {
        private decimal sueldoHora = 800;
        private int horas {  get; set; }
        public DocentePorHora(string nombre, string apellido, int horas) : base(nombre, apellido)
        {
            this.horas = horas;
        }

        public int Horas
        {
            get { return horas; }

            set { horas = (value >= 0) ? value : 0; }
        }


        public override decimal Salario()
        {
            if (horas <= 192)
                return horas * sueldoHora;
            else
                return (192 * sueldoHora) + ((horas - 192) * (sueldoHora * 1.5m));
        }
    }
}
