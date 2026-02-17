using System;

class Program
{
    static void Main()
    {
        int n, sum = 0, num;
        Console.Write("How many numbers you want to enter: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            sum = sum + num;
        }

        Console.WriteLine("Sum is: " + sum);
    }
}
