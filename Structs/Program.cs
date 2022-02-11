using System;

namespace Structs
{
    internal class Program
    {

        public struct Persona
        {
            public string nombre;
        }

        public class CPersona
        {
            public string nombre;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-------STRUCTS----------");
            Persona persona;
            Persona persona1;

            persona.nombre = "David";
            persona1.nombre = "Juan";

            persona = persona1;

            Console.WriteLine(persona.nombre = "123ads");
            Console.WriteLine(persona1.nombre);

            Console.WriteLine("--------CLASSES----------");

            CPersona cpersona = new CPersona();
            CPersona cpersona1 = new CPersona();

            cpersona.nombre = "David";
            cpersona1.nombre = "Juan";
            
            cpersona = cpersona1;

            Console.WriteLine(cpersona.nombre = "asd");
            Console.WriteLine(cpersona1.nombre);

        }
    }
}
