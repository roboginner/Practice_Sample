// sample5.2-1_if01.cs

using System;

class If01
{
    public static void Main()
    {
        int n; // int型の変数nを宣言
        n = 10; // nに10を代入

        if (n > 5)
        {
            Console.WriteLine("nは5より大きい");
        }
        else
        {
            Console.WriteLine("nは5より大きくない");
        }
    }
}