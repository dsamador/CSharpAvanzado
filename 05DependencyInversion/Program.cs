using System;

namespace _05DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Almacen almacen = new Almacen();
            double total = 0;
            
            //0 alimento 1 medicina 2 ropa
            almacen.AdicionaProducto(new Producto("Tomate", 0, 15.50));
            almacen.AdicionaProducto(new Producto("Acetaminofen", 1, 12.50));
            almacen.AdicionaProducto(new Producto("Jeans", 2, 11.50));
            almacen.AdicionaProducto(new Producto("Camiseta", 2, 25.50));
            almacen.AdicionaProducto(new Producto("Ibuprofeno", 1, 16.50));
            almacen.AdicionaProducto(new Producto("Manzana", 0, 13.50));

            Console.WriteLine("---------------");

            Auditor auditor = new Auditor(almacen);

            total = auditor.totalesAlimentos();
            Console.WriteLine($"El total de alimentos es {total}");
        }
    }
}
