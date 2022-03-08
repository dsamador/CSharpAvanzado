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
                    ex.Data.Add("Momento",$"Ocurrio en {DateTime.Now}");
                    ex.Data.Add("Temperatura actual",$"{TempActual} grados");
                    ex.Data.Add("Incremento dado",$"{Aumento} grados");

                    throw ex;
                }
            }
        }
        public void Trabajar2(int Aumento)
        {
            //Ahora lanzamos dos excepciones
            if (Aumento < 0)
                throw new
                    ArgumentOutOfRangeException("Aumento", "El aumento no puede ser negativo");

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

                    CalderaException ex = new CalderaException(
                            $"La caldera {Marca} se ha sobrecalentado",                        
                            DateTime.Now,
                            "Ha trabajado demasiado tiempo"
                        );

                    throw ex;
                }
            }
        }
    }

    public class CalderaException : ApplicationException
    {
        public string Mensaje { get; set; } = "";
        public DateTime Momento { get; set; }
        public string Causa { get; set; }

        public CalderaException(string mensaje, DateTime momento, string causa)
        {
            Mensaje = mensaje;
            Momento = momento;
            Causa = causa;
        }

        public override string Message
        {
            get => $"Mensaje de la excepcion => {Mensaje}";            
        }

    }

    //Excepcion completa de acuerdo a las reglas de .NET
    //Derivar de Exceptiom/ApplicationException
    //Usar [System.Serializable]
    //Definir constructor de default
    //Definir constructor que coloca Message en la herencia
    //Definir constructor que maneja excepciones internas
    //Definir constructor que maneja la serializacion del tipo

    [Serializable]
    public class CalderaException2 : ApplicationException
    {
        public CalderaException2() { }
        public CalderaException2(string Mensaje) : base(Mensaje) { }
        public CalderaException2(string Mensaje, System.Exception inner)
            : base(Mensaje, inner) { }

        protected CalderaException2(
                System.Runtime.Serialization.SerializationInfo info,
                System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

        //Propiedades adicionales
        public string Mensaje { get; set; } = "";
        public DateTime Momento { get; set; }
        public string Causa { get; set; }

        public CalderaException2(string mensaje, DateTime momento, string causa) : base(mensaje)
        {
            Momento = momento;
            Causa = causa;
        }
    }

}
