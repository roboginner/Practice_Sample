// sample7.2-4_simpleclass04.cs

using System;

class SimpleClass04
{
    private int x;

    public static void Main()
    {
        SimpleClass04 s;
        s = new SimpleClass04();
        s.x = 10;
        Console.WriteLine("s.x = " + s.x);
    }
}