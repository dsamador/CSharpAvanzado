using System;
using System.Collections;

namespace Colecciones02BitArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BitArray miArreglo = new BitArray(
                new byte[] { 1, 2, 3, 4, 5, 6, 7 });

            //cantidad de elementos, 5 bytes * 8 = 40 bits
            Console.WriteLine(miArreglo.Count);
            MuestraArreglo(miArreglo);

            Console.WriteLine("--------");

            //obtener bit particular
            Console.WriteLine(miArreglo.Get(3));

            //ponemos un bit en particular
            miArreglo.Set(3, true);
            MuestraArreglo(miArreglo);
            Console.WriteLine(miArreglo.Get(3));
            Console.WriteLine("-------");
        }



        public static void MuestraArreglo(BitArray pArreglo, string pNombre="")
        {
            int c = 0;

            Console.WriteLine($"{pNombre}\t");

            foreach (bool b in pArreglo)
            {
                c++;
                if(b)
                    Console.WriteLine("1");
                else
                    Console.WriteLine("0");
                if(c % 8 == 0)
                    Console.WriteLine(",");
            }
            Console.WriteLine();
        }
    }
}
