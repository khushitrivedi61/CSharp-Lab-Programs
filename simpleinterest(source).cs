using System;

namespace SimpleInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, r, t, si;

            Console.WriteLine("Enter principal amount:");
            p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter rate of interest:");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number of years:");
            t = Convert.ToDouble(Console.ReadLine());

            si = (p * r * t) / 100;
            Console.WriteLine("Simple Interest is: " + si);

            Console.ReadLine();
        }
    }
}
