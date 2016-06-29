// sample3.5-2_type05.cs

using System;

class Type05
{
    public static void Main()
    {
        Console.Write("身長(m)---");
        double bl = double.Parse(Console.ReadLine());
        Console.Write("体重(kg)---");
        double bw = double.Parse(Console.ReadLine());
        Console.WriteLine("BMI = {0:##.#}", bw / Math.Pow(bl, 2.0));
    }
}