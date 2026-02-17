using System;

class Program
{
    static void Main()
    {
        int a, b;
        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        for (int i = a; i <= b; i++)
        {
            int count = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}

