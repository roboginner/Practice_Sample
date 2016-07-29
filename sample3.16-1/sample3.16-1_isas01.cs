// sample3.16-1_isas01.cs

using System;

class Isas01
{
    public static void Main()
    {
        object o;
        long l = 1;
        o = l;

        Console.WriteLine("oにlongをボックス化しました");
        Console.WriteLine("o is long ---{0}", o is long);
        Console.WriteLine("o is int ----{0}", o is int);

        Console.WriteLine();
        Console.WriteLine("今度はoに文字列を代入しました");
        o = "abc";
        Console.WriteLine("o is string--{0}", o is string);
    }
    

}