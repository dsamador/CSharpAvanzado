using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_1_LiskovSubstitution
{
    abstract class Principal
    {
        protected string mensaje;

        public Principal(string mensaje)
        {
            this.mensaje = mensaje;
        }

        //Lo creamos como metodo abstracto para que cada version lo implemente
        public abstract void Muestra();
    }
}
