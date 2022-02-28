using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DependencyInversion
{
    //Clase de bajo nivel
    class Almacen
    {
        //tener en cuenta que la lista es pública
        public List<Producto> Inventario { get; set; }

        public Almacen()
        {
            Inventario = new List<Producto>();
        }

        public void AdicionaProducto(Producto producto)
        {
            Inventario.Add(producto);
            Console.WriteLine($"Adicionamos {producto}");
        }
    }
}
