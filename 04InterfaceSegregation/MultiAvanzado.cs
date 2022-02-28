using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04InterfaceSegregation
{
    internal class MultiAvanzado : IMultifuncional
    {
        enum MyEnum
        {
            Escaneo, Imprimo, Faxeo, Llamo
        }
        public void Escanear()
        {
            Console.WriteLine($" {MyEnum.Escaneo} tu reporte");
        }

        public void Faxear()
        {
            Console.WriteLine($" {MyEnum.Faxeo} tu reporte");
        }

        public void Imprimir()
        {
            Console.WriteLine($" {MyEnum.Imprimo} tu reporte");
        }

        public void Telefono()
        {
            Console.WriteLine($" {MyEnum.Llamo} tu reporte");
        }
    }
}
