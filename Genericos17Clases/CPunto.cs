using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos17Clases
{
    //T representa al tipo con el que se trabaja en un momento dado
    public class CPunto<T>
    {
        //creamos atributos de tipo T
        private T x;
        private T y;

        //podemos recibir parametros de tipo T
        public CPunto(T px, T py)
        {
            x = px;
            y = py;
        }

        public override string ToString()
        {
            return $"X={x}, Y={y}";
        }

        public void Reset()
        {
            // colocamos el valor de default para el tipo T
            // numericos 0
            // referencias null lo que incluye a los strings
            x = default(T);
            y = default(T);
        }

        public void EncuentraTipo()
        {
            if(typeof(T) == typeof(int))
                Console.WriteLine("Trabajo como entero");
            else
                Console.WriteLine("Soy de otro tipo");
        }
    }
}
