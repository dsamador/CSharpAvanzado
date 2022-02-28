using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OpenClose
{
    class InventarioAlimento : BaseInventario
    {
        public InventarioAlimento(Baseinventario producto) : base(producto)
        {

        }

        public override double CalcularProducto()
        {
            Producto.Precio *= 1.2;
            return Producto.Precio;
        }
    }
}
