// sample3.11_scope01.cs

using System;

class Scope01
{
    public static void Main()
    {
        int a = 10;
        Console.WriteLine("a = {0}", a);
        {
            int b = 5;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            {
                int c = 1;
                Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            }
            //ここではcは見えません
            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
        //ここではb, cは見えません
        Console.WriteLine("a = {0}", a);
    }
}