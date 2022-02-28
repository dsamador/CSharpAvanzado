using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OpenClose
{
    abstract class BaseInventario
    {
        public Baseinventario Producto { get; set; }

        protected BaseInventario(Baseinventario producto)
        {
            Producto = producto;
        }

        public override string ToString()
        {
            return Producto.ToString();
        }
        //metodo clave que permite que la implementacion 
        //se haga en las clases de inventario concretas
        public abstract double CalcularProducto();
    }
}
