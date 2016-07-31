// sample6.5_var01.cs

using System;

class Var03
{
    public static void Main()
    {
        var name = new[] { "太郎", "次郎", "三郎", "四郎" };

        for (int i = 0; i < name.Length; i++)
        {
            Console.WriteLine(name[i]);
        }

        var f = new[] { 0.5, 0.9, 1.5, 2.3 };

        for (int i = 0; i < f.Length; i++)
        {
            Console.WriteLine(f[i]);
        }

        Console.WriteLine("nameの型は{0}, fの型は{1}", name.GetType(), f.GetType());
    }
}