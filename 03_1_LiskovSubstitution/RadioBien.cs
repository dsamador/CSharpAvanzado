using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_1_LiskovSubstitution
{
    class RadioBien : Principal
    {
        public RadioBien(string mensaje) : base(mensaje)
        {
        }

        public override void Muestra()
        {
            Console.WriteLine($"Desde el radio: {mensaje}");
        }
    }
}
