// sample7.2-2_simpleclass02.cs

using System;

class MyClass
{
    public int x; // インスタンス変数
}

class SimpleClass02
{
    public static void Main()
    {
        MyClass a, b;
        a = new MyClass(); // オブジェクトを生成
        b = new MyClass(); // オブジェクトをもう一つ生成

        a.x = 10;
        b.x = 100;

        Console.WriteLine("a.x = {0}, b.x = {1}", a.x, b.x);
    }
}