// sample7.2-1_simpleclass01.cs

using System;

class MyClass // クラスを定義
{
    public int x; // インスタンス変数
}

class SimpleClass
{
    public static void Main()
    {
        MyClass mc = new MyClass();
        mc.x = 10;
        Console.WriteLine("mc.x = {0}", mc.x);
    }
}