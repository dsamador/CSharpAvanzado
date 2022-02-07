using System;

namespace Genericos16Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"a={a} y b={b}");
            Intercambio<int>(ref a, ref b);
            Console.WriteLine($"a={a} y b={b}");

            string saludo1 = "a todos";
            string saludo2 = "Hola";

            Console.WriteLine($"{saludo1} {saludo2}");
            Intercambio<string>(ref saludo1, ref saludo2);
            Console.WriteLine($"{saludo1} {saludo2}");
        }

        static void Intercambio<T>(ref T a, ref T b)
        {
            T temporal;
            temporal = a;
            a = b;
            b = temporal;
        }
    }
}
