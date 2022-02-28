using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04InterfaceSegregation
{
    internal class Fax : IFax
    {
        public void Faxear()
        {
            Console.WriteLine("Puedo faxear");
        }

        public void Telefono()
        {
            Console.WriteLine("Puedo llamar");
        }
    }
}
