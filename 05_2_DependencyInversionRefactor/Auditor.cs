using System;
using System.Collections.Generic;

namespace _05_2_DependencyInversionRefactor
{
    class Auditor
    {
        private IAuditable miAlmacen;

        //Ahora el auditor ya no está fuertemente acoplado con el almacén
        public Auditor(IAuditable almacen)
        {
            miAlmacen = almacen;
        }

        public double totalesAlimentos()
        {
            
            double total = 0;
            
            IEnumerable<Producto> listado = miAlmacen.ObtenProductos(0);

            foreach (Producto p in listado)
            {                
                Console.WriteLine(p);
                total += p.Costo;                
            }
            return total;
        }
    }
}
