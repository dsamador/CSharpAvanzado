using System;

//Ciclo de vida de la instancia
    //Heap Administrado
    //Recoleccion de basura
    //Generaciones de objetos



namespace ObjectLifeCicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string video = "https://www.youtube.com/watch?v=zQQvBXPtxl4&list=PLM-p96nOrGcbwP-Z9SYyG3LV-KYwSffWL&index=39";

            Console.WriteLine($"" +
                $"New: *Se crea la instancia del objeto en el heap" +
                $"     \n*Regresa una referencia de ese objeto, no el objeto en si" +
                $"\nVariable: *Se crea en el stack si es una variable local" +
                $"      \n*Guarda la referencia");
            Console.WriteLine($"\n" +
                $"El CLR se encarga del objeto una vez que ha sido creado\n" +
                $"El recolector de basura lo destruira cuando ya no sea necesario\n" +
                $"  *Remueve el objeto cuando ya no puede ser alcanzado por alguna parte del codigo\n" +
                $"  *Ejemplo: cuando se crea localmente en un metodo y este finaliza la ejecucion\n" +
                $"  *No hay garatntia  de que sera destruido exactamente en ese momento" +
                $"\n" +
                $"CREACION DE LA INSTANCIA\n" +
                $"Se calcula la cantidad de memoria requerida para el objeto\n" +
                $"Se verifica que el heap administrado tenga suficiente espacio\n" +
                $"  *Si lo hay, el constructor es invocado y quien lo hizo recibe\n" +
                $"  una referencia al nuevo objeto en memoria.\n" +
                $"  *La direccion es la del \"Apuntador al siguiente objeto\"\n" +
                $"La direccion del apuntado al siguiente objeto es actualizada al siguiente\n" +
                $"espacio disponible");
        }
    }
}
