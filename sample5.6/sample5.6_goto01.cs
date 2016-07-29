// sample5.6_goto01.cs

using System;

class GoTo01
{
    public static void Main()
    {
        Console.WriteLine("ここからジャンプします");
        goto jump01;
        Console.WriteLine("これは、表示されません");

        jump01:
        Console.WriteLine("ここまで飛んできました");
        Console.WriteLine("プログラムを終了します");
    }
}