//sample3.10-2_Dynamics01.cs

using System;

class Dynamics01
{
    public static int Main()
    {
        dynamic x = 10, y = "abc", z = 1.25;

        Console.WriteLine("x ---- {0}", x.GetType());
        Console.WriteLine("y ---- {0}", y.GetType());
        Console.WriteLine("z ---- {0}", z.GetType());

        return 0;
    }
}