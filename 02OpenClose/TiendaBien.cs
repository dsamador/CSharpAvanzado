using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OpenClose
{
    public class TiendaBien
    {
        private List<BaseInventario> productos;

        public TiendaBien(List<BaseInventario> productos)
        {
            this.productos = productos;
        }

        public void calcularInventario()
        {
            double total = 0;
            foreach (var producto in productos)
            {
                producto.CalcularProducto();
                Console.WriteLine(producto);
                total += producto.Producto.Precio;
            }
            Console.WriteLine($"El total del inventario es {total}");
        }
    }
}
