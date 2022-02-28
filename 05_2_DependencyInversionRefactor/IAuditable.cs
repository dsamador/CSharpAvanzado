using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_2_DependencyInversionRefactor
{
    interface IAuditable
    {
        //Retorna una lista de productos de acuerdo al tipo
        IEnumerable<Producto> ObtenProductos(int Tipo);
    }
}
