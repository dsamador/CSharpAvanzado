using System;
using System.Collections.Generic;

namespace _02OpenClose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Baseinventario> productos = new List<Baseinventario>
            {
                new Baseinventario("papas", 1, 12.5),
                new Baseinventario("pollo", 1, 12.5),
                new Baseinventario("pastillas", 2, 12.5),
                new Baseinventario("fruta", 1, 12.5),
                new Baseinventario("tv", 2, 22.5),
                new Baseinventario("celular", 2, 12.5)
            };

            Tienda tienda = new Tienda(productos);

            tienda.calcularInventario();
        }
    }
}
