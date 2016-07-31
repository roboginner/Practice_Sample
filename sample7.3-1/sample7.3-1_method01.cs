// sample7.3-1_method01.cs

using System;

class MyClass
{
    public int Add(int x, int y)
    {
        int z;
        z = x + y;
        return z;
    }
}

class Method01
{
    public static void Main()
    {
        MyClass a = new MyClass();
        int sum;
        sum = a.Add(100, 200); // Addメソッドを呼び出す
        Console.WriteLine("sum = {0}", sum);
    }
}