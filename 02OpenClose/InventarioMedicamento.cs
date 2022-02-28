
namespace _02OpenClose
{
    class InventarioMedicamento : BaseInventario
    {
        public InventarioMedicamento(Baseinventario producto) : base(producto)
        {
        }

        public override double CalcularProducto()
        {
            Producto.Precio *= 1.2;
            return Producto.Precio;
        }
    }
}
