// sample2.4-3_text05
// フォーマット指定子を使った表示桁数の指定

using System;

class Text05
{
    public static void Main()
    {
        int x = 10, y = 123456789;

        Console.WriteLine("123456789012345678901234567890");
        Console.WriteLine("{0, 10}", "abc");
        Console.WriteLine("{0, 5}", "def");
        Console.WriteLine("{0, 0}", "ghi");
        Console.WriteLine("{0, 10}{1, 10}", "あ", "い");
        Console.WriteLine("{0, -10}{1, -10}", "あ", "い");
        Console.WriteLine("x = {0, 5}, y = {1, 3}", x, y);
    }
}