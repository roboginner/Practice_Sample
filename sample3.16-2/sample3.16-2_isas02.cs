// sample3.16-2_isas02.cs

using System;

class Isas02
{
    public static void Main()
    {
        long l = 100;
        object o;
        string s;

        o = l;
        s = o as string;
        Console.WriteLine(o);
    }
}