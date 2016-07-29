// sample5.4-6_sin01.cs

using System;

class Sin01
{
    public static void Main()
    {
        double s;

        for (double a = 0.0; a <= Math.PI; a += Math.PI / 45)
        {
            s = Math.Sin(a);
            Console.Write("{0,7:#.#####}:", s);

            for (int i = 1; i <= Math.Round(s * 50); i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}