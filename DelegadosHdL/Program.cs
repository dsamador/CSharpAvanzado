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
            //Action se usa para funciones que no retornan nada
            Action<string, string> mostrar = Show;            
            HacerAlgo(mostrar);
        }

        public static void HacerAlgo(Action<string, string> funcionFinal)
        {
            Console.WriteLine("Hago algo");
            funcionFinal("se envio desde otra funcion","  ");
            Console.WriteLine("Hago algo mas");
        }      

        public static void Show(string cad, string cad2)
        {
            Console.WriteLine(cad + cad2);
        }

        public static int Show(string cad)
        {
            return cad.Count();
        }

        
    }
}
