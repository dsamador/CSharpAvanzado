using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SingleResponsability
{
    //Clase que no aplica el principio
    public class Empleado
    {
        private string nombre;
        private string puesto;
        private int edad;
        private double sueldo;

        public Empleado(string nombre, string puesto, int edad, double sueldo)
        {
            this.nombre = nombre;
            this.puesto = puesto;
            this.edad = edad;
            this.sueldo = sueldo;
        }

        public override string ToString()
        {
            return $"{nombre} {puesto} {edad} {sueldo}";
        }

        //Metodos que no son responsabilidad del empleado
        //Razones:
        //Cuando cambia algo del empleado
        //Cuando cambia algo relacionado con los impuestos, la ley cambia

        public double CalcularImpuesto()
        {
            return sueldo * 0.35;
        }

        public void PagarImpuesto()
        {
            double imp = CalcularImpuesto();
            Console.WriteLine($"Se pago {imp} por parte de {nombre}");
        }

    }
}
