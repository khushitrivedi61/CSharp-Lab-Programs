using System;

class Program
{
    static void Main()
    {
        int num, rem, rev = 0;
        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());
        int temp = num;

        while (num > 0)
        {
            rem = num % 10;
            rev = rev * 10 + rem;
            num = num / 10;
        }

        if (temp == rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}