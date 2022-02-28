using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_1_LiskovSubstitution
{
    class Radio:Noticiero
    {
        public Radio(string mensaje) : base(mensaje)
        {

        }
        //public new void Muestra()
        //{
        //    Console.WriteLine($"Desde la radio: {mensaje}");
        //}
        public override void Muestra()
        {
            Console.WriteLine($"Desde la radio: {mensaje}");
        }

    }    
}
