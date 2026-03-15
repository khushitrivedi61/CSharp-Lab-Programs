using System;

class Program
{
    static void Main()
    {
        int n, first = 0, second = 1, next;

        Console.Write("Enter a number: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");

        while (first <= n)
        {
            Console.Write(first + " ");
            next = first + second;
            first = second;
            second = next;
        }
    }
}
