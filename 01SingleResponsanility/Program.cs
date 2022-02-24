using System;

namespace _01SingleResponsability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpleadoMal empleado = new EmpleadoMal("Juan", "Dev", 24, 3000);
            Console.WriteLine(empleado);
            empleado.PagarImpuesto();
            
            EmpleadoBien empleado2 = new EmpleadoBien("David", "Dev", 24, 3000);
            Console.WriteLine(empleado2);
            Console.WriteLine(Hacienda.CalcularImpuesto(empleado2)); 
            Hacienda.PagarImpuesto(empleado2);
        }
    }
}
