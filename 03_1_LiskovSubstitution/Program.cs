using System;

namespace _03_1_LiskovSubstitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Noticiero noticiero = new ("Hola a todos");
            //noticiero.Muestra();

            //Radio radio = new ("Como estan?");
            //radio.Muestra();

            //Console.WriteLine("---------");

            //sustituimos la clase hija y vemos como se comportan
            //Noticiero sustitucion = new Radio("Probando");
            //sustitucion.Muestra();

            Principal noticiero = new NoticieroBien("Hola noticiero");
            noticiero.Muestra();
            
            Principal radio = new NoticieroBien("Hola radio");
            radio.Muestra();
        }
    }
}
