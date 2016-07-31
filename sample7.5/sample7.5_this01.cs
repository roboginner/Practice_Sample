// sample7.5_this01.cs

using System;

class MyClass
{
    public MyClass m1, m2;

    public void Test()
    {
        m2 = this;
    }

    public MyClass()
    {
        m1 = this;
    }
}

class This01
{
    public static void Main()
    {
        MyClass mc = new MyClass();

        mc.Test();

        if (mc.m1 == mc.m2)
        {
            Console.WriteLine("m1とm2は同じです");
        }

        if (mc == mc.m1)
        {
            Console.WriteLine("mcとm1は同じです");
        }

        if (mc == mc.m2)
        {
            Console.WriteLine("mcとm2は同じです");
        }
    }
}