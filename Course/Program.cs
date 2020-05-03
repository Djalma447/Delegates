using System;
using Course.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 12;
            double b = 10;

            double r1 = CalculationService.Max(a, b);
            double r2 = CalculationService.Sum(a, b);
            double r3 = CalculationService.Square(a);
            Console.WriteLine(r1 + " " + r2 + " " + r3);
        }
    }
}
