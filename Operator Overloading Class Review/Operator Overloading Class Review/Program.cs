using System;

namespace Operator_Overloading_Class_Review
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manat manat = new Manat(340);
            Dollar dollar = manat;
            Console.WriteLine(dollar.Usd);

            
            
        }

    }


    public class Dollar
    {
        public double Usd { get; set; }
        public Dollar(double usd)
        { 
            Usd = usd;
        }

        
    }

    public class Manat
    {
        public double Azn { get; set; }
        public Manat(double azn)
        {
            Azn = azn;
        }

        public static implicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.Azn / 1.7);
        }
    }

    
}