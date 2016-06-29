// sample2.4-4_text06.cs
// 標準書式指定文字を使った書式の指定

using System;

class Text06
{
    public static void Main()
    {
        Console.WriteLine("D{0, 10:D}", 123);
        Console.WriteLine("X{0, 10:X}", 123);
        Console.WriteLine("E{0, 10:E}", 123.456);
        Console.WriteLine("F{0, 10:F}", 123.456);
        Console.WriteLine("F{0, 10:F5}", 123.456);
        Console.WriteLine("C{0, 10:C}", 123456);
        Console.WriteLine("N{0, 10:N}", 1234.4568);
        Console.WriteLine("P{0, 10:P}", 0.05);
        Console.WriteLine("G{0, 10:G}", 123.456);
    }
}