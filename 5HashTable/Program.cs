using System;
using System.Collections;

namespace _5HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hashtable miTabla = new Hashtable();

            //Los valores pueden ser cualquier cosa, literalmente

            miTabla.Add(123, "Hola");
            miTabla.Add(234, "Saludos");
            miTabla.Add(45, "Adios");
            miTabla.Add(567, "C#");
            miTabla.Add(12763, "Programacion");

            //Mostramos los elementos
            foreach (DictionaryEntry item in miTabla)
            {
                Console.WriteLine($"{item.Key}, {item.Value}");
            }

            //Intentamos colocar un elemento con llave repetida
            //miTabla.Add(123, "Otro mas");

            //Cantidad de elementos
            Console.WriteLine(miTabla.Count);

            //Obtenemos el elemento de determinada llave
            Console.WriteLine(miTabla[567]);
            Console.WriteLine(miTabla[777]);//vacio
        }
    }
}
