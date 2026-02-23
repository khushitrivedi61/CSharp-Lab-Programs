using System;

class Program
{
    static void Main()
    {
        int num, rem, sum = 0;
        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());
        int temp = num;
        int digits = num.ToString().Length;

        while (num > 0)
        {
            rem = num % 10;
            sum += (int)Math.Pow(rem, digits);
            num = num / 10;
        }

        if (temp == sum)
            Console.WriteLine("Armstrong");
        else
            Console.WriteLine("Not Armstrong");
    }
}