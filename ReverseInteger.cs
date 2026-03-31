using System;

class Solution
{
    public int Reverse(int x)
    {
        int sign = x < 0 ? -1 : 1;
        string digits = Math.Abs((long)x).ToString();
        char[] arr = digits.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);
        long result = sign * long.Parse(reversed);
        if (result < int.MinValue || result > int.MaxValue)
        {
            return 0;
        }
        return (int)result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();

        Console.Write("Enter integer: ");
        int x = int.Parse(Console.ReadLine());

        int output = sol.Reverse(x);
        Console.WriteLine("Reversed: " + output);
    }
}
