using System;

class Program
{
    static void Main()
    {
        double r, area;
        Console.WriteLine("Enter the radius of the circle:");
        r = Convert.ToDouble(Console.ReadLine());
        area = Math.PI * r * r;
        Console.WriteLine("Area of the circle is: " + area);
    }
}
