using System;
using System.Linq;
using System.Threading.Tasks;

namespace DelegadosHdL
{
    internal class Program
    {        
        static async Task Main(string[] args)
        {
            //El ultimo parametro es lo que se regresa, si tiene uno solo
            //regresa ese tipo, si tiene dos o mas todos menos el ultimo
            //son parametros que recibe, Func debe tener al menos el tipo de 
            //regreso
            Func<string, int> mostrar = Show;            
            HacerAlgo(mostrar);
        }

        public static void HacerAlgo(Func<string, int> funcionFinal)
        {
            Console.WriteLine("Hago algo");
            funcionFinal("se envio desde otra funcion");
            Console.WriteLine("Hago algo mas");
        }      

      

        public static int Show(string cad)
        {
            return cad.Count();
        }

        
    }
}
