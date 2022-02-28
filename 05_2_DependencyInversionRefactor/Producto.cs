using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_2_DependencyInversionRefactor
{
    class Producto
    {
        public string Nombre { get; set; }
        public int Tipo { get; set; }// 1 alimento, 2 medicina, 3 ropa
        public double Costo { get; set; }

        public Producto(string nombre, int tipo, double costo)
        {
            Nombre = nombre;
            Tipo = tipo;
            Costo = costo;
        }

        public override string ToString()
        {
            string strTipo = "";

            if (Tipo == 0)
                strTipo = "Alimento";

            else if (Tipo == 1)
                strTipo = "Medicina";

            else if (Tipo == 2)
                strTipo = "Ropa";

            return $"{Nombre} tipo {strTipo}, costo {Costo}";
        }
    }
}
