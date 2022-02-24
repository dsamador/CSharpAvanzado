using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SingleResponsability
{
    class Hacienda
    {
        public static double CalcularImpuesto(EmpleadoBien empleadoBien)
        {
            return empleadoBien.Sueldo * 0.35;
        }

        public static void PagarImpuesto(EmpleadoBien empleadoBien)
        {
            double imp = CalcularImpuesto(empleadoBien);
            Console.WriteLine($"Se pago {imp} por parte de {empleadoBien.Nombre}");
        }
    }
}
