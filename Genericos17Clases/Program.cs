using System;

namespace Genericos17Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Para puntoI, T trabaja como int
            CPunto<int> puntoI = new CPunto<int>(3, 4);

            //para puntoD, T trabaja como double
            CPunto<double> puntoD = new CPunto<double>(3.3, 4.8);
            
            //Para puntoF T trabaja como float
            CPunto<float> puntoF = new CPunto<float>(3.33f, 4.84f);

            Console.WriteLine(puntoI);
            Console.WriteLine(puntoD);
            Console.WriteLine(puntoF);
            
            //colocamos el valor de default
            puntoI.Reset();
            Console.WriteLine(puntoI);

            //verificamos si trabaja como entero
            puntoI.EncuentraTipo();
            puntoD.EncuentraTipo(); 
        }
    }
}
