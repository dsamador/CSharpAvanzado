using System;
using System.Linq;
using System.Threading.Tasks;

namespace DelegadosHdL
{
    internal class Program
    {
        public delegate void Mostrar(string cadena);
        static async Task Main(string[] args)
        {
            //El ultimo parametro es lo que se regresa, si tiene uno solo
            //regresa ese tipo, si tiene dos o mas todos menos el ultimo
            //son parametros que recibe, Func debe tener al menos el tipo de 
            //regreso
            Func<string, int> mostrar = Show;
            Mostrar mostrar2 = Show;
            HacerAlgo(mostrar);
        }

        public static void HacerAlgo(Mostrar funcionFinal)
        {
            Console.WriteLine("Hago algo");
            funcionFinal("se envio desde otra funcion");
            Console.WriteLine("Hago algo mas");
        }
        public static void HacerAlgo2(Func<string, int> funcionFinal)
        {
            Console.WriteLine("Hago algo");
            funcionFinal("se envio desde otra funcion");
            Console.WriteLine("Hago algo mas");
        }

        public static void Show(string cad)
        {
            Console.WriteLine("Hola soy un delegado" + cad);
        }

        public static int ShowLenCad(string cad)
        {
            return cad.Count();
        }
    }
}
