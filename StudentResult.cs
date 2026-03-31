using System;

interface IPass
{
    bool Pass(int mark);
}

interface IDivision
{
    string Division(int average);
}

class Student : IPass, IDivision
{
    public bool Pass(int mark)
    {
        if (mark >= 50)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string Division(int average)
    {
        if (average >= 75)
        {
            return "First Division";
        }
        else if (average >= 60)
        {
            return "Second Division";
        }
        else if (average >= 50)
        {
            return "Third Division";
        }
        else
        {
            return "Fail";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();

        Console.Write("Enter marks: ");
        int mark = int.Parse(Console.ReadLine());

        bool result = s.Pass(mark);
        string div = s.Division(mark);

        Console.WriteLine("Pass: " + result);
        Console.WriteLine("Division: " + div);
    }
}
