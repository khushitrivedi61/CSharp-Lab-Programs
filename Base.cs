// Create a class that contains instance variables such as var1 and var2. Derive two classes from it named A and B.
// The A class should include an additional instance variable called extraA, while the B class should include an instance variable called extraB.

using System;

class Base
{
    public int var1;
    public int var2;
}

class A : Base
{
    public int extraA;
}

class B : Base
{
    public int extraB;
}

class Program
{
    static void Main()
    {
        A a = new A();
        a.var1 = 10;
        a.var2 = 20;
        a.extraA = 30;

        B b = new B();
        b.var1 = 40;
        b.var2 = 50;
        b.extraB = 60;

        Console.WriteLine(a.var1 + " " + a.var2 + " " + a.extraA);
        Console.WriteLine(b.var1 + " " + b.var2 + " " + b.extraB);
    }
}