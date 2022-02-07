using System;
using System.Collections;

namespace Colecciones01ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ArrayList palabras = new ArrayList();

            int n = 0;
            int r = 0;

            //podemos adicionar con rango
            //Se pasa una coleccion como parametro
            palabras.AddRange(new string[] { "Hola", "como", "estan?" });

            Console.WriteLine("Cantidad de elementos en el ArrayList es {0}", 
                palabras.Count);

            for (n = 0; n < palabras.Count; n++)
            {
                Console.WriteLine($"{palabras[n]}");
            }

            Console.WriteLine();
            Console.WriteLine("-------");

            //otra forma de adicionar elementos
            palabras.Add("Bien y tu?");

            ArrayList valores = new ArrayList();

            valores.Add(4);
            valores.Add(49);
            valores.Add(34);
            valores.Add(12);

            //podemos saber si tiene determinado numero
            Console.WriteLine(valores.Contains(34));
            Console.WriteLine("----------");

            for (n = 0; n < valores.Count; n++)
            {
                //todo se guarda como object, toca hacer type cast
                r = (int)valores[n];
                Console.WriteLine(r);
            }

            //se puede insertar un dato en un indice particular
            //insertamos el 55 en la posicion 2
            valores.Insert(2, 55);

            //quitar determinado numero
            valores.Remove(55);

            //quitar elemento por indice que exista
            valores.RemoveAt(0);
                        
        }
    }
}
