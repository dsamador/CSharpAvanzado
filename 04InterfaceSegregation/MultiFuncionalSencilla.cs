using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04InterfaceSegregation
{
    internal class MultiFuncionalSencilla : IMultifuncional
    {
        public void Escanear()
        {
            Console.WriteLine("Escaneo");
        }

        //Tenemos métodos que no usamos
        public void Faxear()
        {
            throw new NotImplementedException();
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimo");
        }

        public void Telefono()
        {
            throw new NotImplementedException();
        }
    }
}
