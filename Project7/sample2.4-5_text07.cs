// sample2.4-5_text07.cs
// カスタム書式指定文字を使った書式の指定

using System;

class Text07
{
    public static void Main()
    {
        Console.WriteLine("{0, 10:0000.00}", 1.2);
        Console.WriteLine("{0, 10:####.##}", 1.2);
        Console.WriteLine();
        Console.WriteLine("{0, 10:0,0}", 123456);
        Console.WriteLine("{0, 10;#,#}", 123456);
        Console.WriteLine();
        Console.WriteLine("{0, 10:0,00000000.00}", 123456);
        Console.WriteLine("{0, 10:#,########.##}", 1113204566);
        Console.WriteLine("{0:(000)####-####}");
    }
}