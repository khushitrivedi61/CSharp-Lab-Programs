using System;

class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        string s = x.ToString();
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);
        if (s == reversed)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution sol = new Solution();

        Console.Write("Enter a number: ");
        int x = int.Parse(Console.ReadLine());

        bool result = sol.IsPalindrome(x);
        if (result == true)
        {
            Console.WriteLine(x + " is a Palindrome");
        }
        else
        {
            Console.WriteLine(x + " is not a Palindrome");
        }
    }
}
