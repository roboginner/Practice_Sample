// sample3.14-2_object02.cs

using System;

class Object02
{
    public static void Main()
    {
        object o;
        int i, a = 100;

        o = a;      // ボックス化
        i = (int)o; // ボックス化解除
        Console.WriteLine("i = {0}", o);
    }
}