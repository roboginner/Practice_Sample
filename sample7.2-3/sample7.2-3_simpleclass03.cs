// sample7.2-3_simpleclass03.cs

using System;

class MyClass
{
    public int x;
}

class SimpleClass03
{
    public static void Main()
    {
        MyClass a, b;
        a = new MyClass();
        a.x = 10;
        b = a;

        Console.WriteLine("b.x = {0}", b.x);
        b.x = 100;
        Console.WriteLine("a.x = {0}", a.x);
    }
}