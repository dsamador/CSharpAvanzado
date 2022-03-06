using System.Collections.Generic;
using System;

namespace ExpresionLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //hacemos uso de la expresion lambda
            List<int> pares = numeros.FindAll(i => (i % 2 == 0));

            //mostramos los numeros
            foreach (int i in pares)
                Console.Write(i);

            Console.WriteLine("---------------");

            List<int> paresTexto = numeros.FindAll(i =>
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} Un par");
                    return true;
                }
                else
                {
                    Console.WriteLine($"{i} Un impar");
                    return false;
                }
            });
        }
    }
}