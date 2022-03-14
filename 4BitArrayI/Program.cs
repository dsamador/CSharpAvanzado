using System;
using System.Collections;


//Conociendo BitArray
//Colocar elementos en constructor
//Recorrer el BitArray
//Uso de Count
//Obtener y colocar un bit en particular

//BitArray es una coleccion de bits

namespace _4BitArrayI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BitArray miArreglo = new BitArray(new byte[] { 1, 2, 3, 4 });

            //Cantidad de elementos
            Console.WriteLine(miArreglo.Count);
            MuestraArreglo(miArreglo);
            Console.WriteLine("--------");
            
            //Obtener un bit particular
            Console.WriteLine(miArreglo.Get(0));

            //Poner un bi particular
            miArreglo.Set(3, true);
            MuestraArreglo(miArreglo);
            Console.WriteLine(miArreglo.Get(0));
            Console.WriteLine("--------");

        }



        public static void MuestraArreglo(BitArray arreglo, string nombre="")
        {
            int a = 0;

            Console.Write($"{nombre}\t");

            foreach (bool b in arreglo)
            {
                a++;
                if(b)
                    Console.Write("1");
                else
                    Console.Write("0");
                if(a % 8 == 0)
                    Console.Write(",");
            }
            Console.WriteLine();
        }
    }
}
