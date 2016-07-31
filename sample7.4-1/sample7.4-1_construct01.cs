// sample7.4-1_construct01.cs

using System;

class MyClass
{
    int x;

    public void ShowX()
    {
        Console.WriteLine("x = " + x);
    }

    public MyClass()
    {
        x = 10;
        Console.WriteLine("xに10を代入しました");
    }
}

class Constructor01
{
    public static void Main()
    {
        // newしたときにコンストラクタが呼び出される
        MyClass mc = new MyClass();
        mc.ShowX();
    }
}