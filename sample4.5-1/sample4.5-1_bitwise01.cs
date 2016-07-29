// smaple4.5-1_bitwise01.cs

using System;

class BitWise01
{
    public static void Main()
    {
        byte a = 2, b = 3;
        Console.WriteLine(a & b);
        Console.WriteLine(a | b);
        Console.WriteLine(a ^ b);
        Console.WriteLine();

        bool x = true, y = false;
        Console.WriteLine(x & x);
        Console.WriteLine(x & y);
        Console.WriteLine(y & y);
        Console.WriteLine();

        Console.WriteLine(x | x);
        Console.WriteLine(x | y);
        Console.WriteLine(y | y);
        Console.WriteLine();

        Console.WriteLine(x ^ x);
        Console.WriteLine(x ^ y);
        Console.WriteLine(y ^ y);
    }
}