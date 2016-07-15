// sample3.14-2_object03.cs --- 実行時エラー注意！！

using System;

class Object03
{
    public static void Main()
    {
        long l = 1;
        object o;
        int i;

        o = l;
        i = (int)o;

        Console.WriteLine(i);
    }
}