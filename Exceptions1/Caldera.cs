using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions1
{
    public class Caldera
    {
        public int TempMax { get; } = 120;
        public int TempActual { get; set; } = 0;
        public string Marca { get; set; } = "";
        public bool Funciona { get; set; } = true;

        public Caldera(int tempActual, string marca)
        {
            TempActual = tempActual;
            Marca = marca;
        }
        //Sin excepciones
        //public void Trabajar(int Aumento)
        //{
        //    if(Funciona == false)
        //        Console.WriteLine($"La caldera {Marca} esta descompuesta");
        //    else
        //    {
        //        TempActual += Aumento;
        //        Console.WriteLine($"La temperatura actual es de {TempActual}");
        //        if(TempActual > TempMax)
        //        {
        //            Console.WriteLine($"{Marca} supero la temperatura, " +
        //                $"tiene {TempActual} ");
        //            TempActual = TempMax;
        //            Funciona = false;
        //        }
        //    }            
        //}

        public void Trabajar(int Aumento)
        {
            if (Funciona == false)
                Console.WriteLine($"La caldera {Marca} esta descompuesta");
            else
            {
                TempActual += Aumento;
                Console.WriteLine($"La temperatura actual es de {TempActual}");
                if (TempActual > TempMax)
                {
                    Console.WriteLine($"{Marca} supero la temperatura, " +
                        $"tiene {TempActual} ");
                    TempActual = TempMax;
                    Funciona = false;

                    Exception ex = new Exception($"La caldera {Marca} se sobrecalienta");
                    ex.HelpLink = "https://www.jw.org";
                    throw ex;
                }
            }
        }
    }
}
