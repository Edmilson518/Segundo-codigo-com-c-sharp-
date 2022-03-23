using System;
namespace ConversionTypeSafe
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 10;
            short b = a;
            int c = b;
            long d = c;
            float e = d;
            double f = e;

           Console.Write(f);
           Console.Read();
        }
    }
}


// Listagem 1. Conversão Implícita de ValueType