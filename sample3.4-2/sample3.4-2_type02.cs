// sample3.4-2_type02

using System;

class Type02
{
    public static void Main()
    {
        Console.Write("整数を入力してください---");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("今の数を二倍すると{0}ですね。", x * 2);

        Console.Write("あなたの年齢を入力してください---");
        ushort age = ushort.Parse(Console.ReadLine());
        Console.WriteLine("あと{0}年で100歳ですね", 100 - age);
    }
}