using System;

namespace Operator_Overloading_Class_Review
{
    public class Program1
    {
        static void Main(string[] args)
        {
            Kelvin kelvin = new Kelvin(300);
            Celcius celcius = kelvin;
            Console.WriteLine(celcius.C);
            



        }

    }


    public class Celcius
    {
        public double  C { get; set; }
        public Celcius (double degree)
        {
           C = degree;
        }


    }

    public class Kelvin
    {
        public double K{ get; set; }
        public Kelvin(double degree)
        {
            K = degree;
        }


        public static implicit operator Celcius (Kelvin kelvin)
        {
            return new Celcius(kelvin.K - 273);
        }
        
    }


}