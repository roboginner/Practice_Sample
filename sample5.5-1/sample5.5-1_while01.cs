// sample5.5-1_while01.cs

using System;

class While01
{
    public static void Main()
    {
        int i = 0;

        while (i < 100)
        {
            Console.WriteLine("i = {0,3}", i);
            i++;
        }
    }
}