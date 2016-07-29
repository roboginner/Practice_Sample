// sample4.3-1_increment01.cs

using System;

class Increment01
{
    public static void Main()
    {
        int a = 10;
        Console.WriteLine(a++);
        Console.WriteLine(a);

        int b = 10;
        Console.WriteLine(++b);
        Console.WriteLine(b);
    }
}