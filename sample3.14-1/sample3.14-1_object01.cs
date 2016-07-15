// sample3.14-1_object01.cs

using System;

class Object01
{
    public static void Main()
    {
        object o;
        byte b = 50;
        int i = 10;
        long l = 55555;
        double d = 0.00254;

        o = b;                  // byte型の値を代入
        Console.WriteLine(o);

        o = i;                  // int型の値を代入
        Console.WriteLine(o);

        o = l;                  // long型の値を代入
        Console.WriteLine(o);

        o = d;                  // double型の値を代入
        Console.WriteLine(d);
    }
}