using System;

namespace _01SingleResponsability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Juan", "Dev", 24, 3000);
            Console.WriteLine(empleado);
            empleado.PagarImpuesto();
        }
    }
}
