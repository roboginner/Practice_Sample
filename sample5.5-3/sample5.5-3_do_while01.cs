// sample5.5-3_do_while01.cs

using System;

class Do_while01
{
    public static void Main()
    {
        int i = 10;

        do
        {
            Console.WriteLine("i = {0}", i);
        } while (i > 20); // 常に偽だが、一度は実行される
    }
}