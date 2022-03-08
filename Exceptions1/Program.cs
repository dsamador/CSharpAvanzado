using System;
using System.Collections;

namespace Exceptions1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Caldera caldera = new Caldera(20, "Matic-O");

            //for (int i = 0; i < 10; i++)
            //{
            //    caldera.Trabajar(20);
            //}

            try
            {
                for (int i = 0; i < 10; i++)                
                    caldera.Trabajar(20);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("\nSe ha liao parda");
                Console.WriteLine($"En este metodo: {e.TargetSite}");
                Console.WriteLine("Con este mensaje de error: " +
                    $"{e.Message}");
                Console.WriteLine($"Fuente: {e.Source}");

                Console.WriteLine($"Clase donde ocurrio: " +
                    $"{e.TargetSite.DeclaringType}");
                
                Console.WriteLine($"Tipo de miembro: " +
                    $"{e.TargetSite.MemberType}");

                Console.WriteLine($"Stack: {e.StackTrace}");
                Console.WriteLine($"Ayuda: {e.HelpLink}");

                Console.WriteLine("Datos propios");

                if(e.Data != null)
                {
                    foreach(DictionaryEntry entry in e.Data)
                        Console.WriteLine($"-> {entry.Key} -> {entry.Value}");
                }

            }
        }
    }
}
