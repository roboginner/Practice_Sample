// sample5.4-5_kuku01.cs

using System;
class Kuku01
{
    public static void Main()
    {
        int i, j;

        for (i = 1; i <= 9; i++)
        {
            for (j = 1; j <= 9; j++)
            {
                Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
            }
            Console.WriteLine("-------------");
        }
    }
}