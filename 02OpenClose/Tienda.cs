using System;
using System.Collections.Generic;

namespace _02OpenClose
{
    /*
     * Un cambio en el requerimiento: 
     * Se necesita que haya un descuento del precio de productos cat 1
     * Se necesita que haya un aumento del precio de productos cat 2    
     */
    class Tienda
    {
        private List<Baseinventario> productos;

        public Tienda(List<Baseinventario> productos)
        {
            this.productos = productos;
        }

        public void calcularInventario()
        {
            double total = 0;

            //foreach (var item in productos)
            //{
            //    Console.WriteLine(item);
            //    total += item.Precio;
            //}

            //cambio de precio
            //estamos modificando la clase, esto esta mal.
            foreach(Baseinventario p in productos)
            {
                if (p.Categoria == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    p.Precio *= 0.8;
                    Console.WriteLine(p);
                    total += p.Precio;
                }
                if (p.Categoria == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    p.Precio *= 1.2;
                    Console.WriteLine(p);
                    total += p.Precio;
                }
            }

            Console.WriteLine($"El total del inventario es {total} \n");
        }
    }
}
