// sample5.4-4_for04

using System;

class For04
{
    public static void Main()
    {
        int i;

        for (i = 0; ; i++)
        {
            if (i >= 5) break;

            Console.WriteLine("i = {0}", i);
        }
    }
}