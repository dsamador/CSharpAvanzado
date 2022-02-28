using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_2_DependencyInversionRefactor
{
    class Almacen
    {
        //Ya no hay necesidad de dar acceso a la lista
        private List<Producto> inventario;

        public Almacen()
        {
            inventario = new List<Producto>();
        }

        public void AdicionaProducto(Producto producto)
        {
            inventario.Add(producto);
            Console.WriteLine($"Adicionamos {producto.Nombre}");
        }
        //Implementación de la interfaz, hacemos la búsqueda flexible
        public IEnumerable<Producto> ObtenProductos(int Tipo)
        {
            List<Producto> encontrados = new List<Producto>();

            foreach (Producto producto in inventario)
            {
                if (producto.Tipo == Tipo)
                    encontrados.Add(producto);
            }
            return encontrados;
        }
    }
}
