using System;

class ForLoopConcepts
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== 1. Basic For Loop (1 to 10) ===");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Number: " + i);
        }

        Console.WriteLine("\n=== 2. Even Numbers from 1 to 20 ===");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " is Even");
            }
        }

        Console.WriteLine("\n=== 3. Sum of Numbers from 1 to 100 ===");
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine("Sum = " + sum);

        Console.WriteLine("\n=== 4. Multiplication Table of 5 ===");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("5 x " + i + " = " + (5 * i));
        }

        Console.WriteLine("\n=== 5. Reverse Loop (10 to 1) ===");
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\n=== 6. Factorial of a Number ===");
        Console.Write("Enter a number for factorial: ");
        int n = int.Parse(Console.ReadLine());
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("Factorial of " + n + " = " + factorial);

        Console.WriteLine("\n=== 7. Nested For Loop - Pattern ===");
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n=== 8. Array Iteration using For Loop ===");
        int[] marks = { 85, 90, 45, 78, 60 };
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine("Student " + (i + 1) + " Marks: " + marks[i]);
        }
    }
}
