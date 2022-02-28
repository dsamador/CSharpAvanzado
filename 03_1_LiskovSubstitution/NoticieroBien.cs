using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_1_LiskovSubstitution
{
    internal class NoticieroBien : Principal
    {
        public NoticieroBien(string mensaje) : base(mensaje)
        {
        }

        public override void Muestra()
        {
            Console.WriteLine($"Desde el noticiero {mensaje}");
        }
    }
}
