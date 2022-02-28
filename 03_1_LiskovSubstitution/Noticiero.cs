using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_1_LiskovSubstitution
{
    class Noticiero
    {
        protected string mensaje;

        public Noticiero(string mensaje)
        {
            this.mensaje = mensaje;
        }

        //para primera prueba
        //public void Muestra()
        //{
        //    Console.WriteLine($"Desde el noticiero: {mensaje}");
        //}
        public virtual void Muestra()
        {
            Console.WriteLine($"Desde el noticiero: {mensaje}");
        }

    }
}
