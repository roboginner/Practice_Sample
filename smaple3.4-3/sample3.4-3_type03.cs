// sample3.4-3_tyoe03.cs

using System;

class Type03
{
    public static void Main()
    {
        Console.Write("整数を入力してください---");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("今の数字を二倍すると{0}ですね", x * 2);

        Console.Write("あなたの年齢を入力してください");
        ushort age = Convert.ToUInt16(Console.ReadLine());
        Console.WriteLine("あと{0}年で100歳ですね。", 100 - age);
    }
}