// sample6.1-1_average01.cs

using System;

class Average01
{
    public static void Main()
    {
        int tanaka = 70, yamada = 80, satoh = 50, sum = 0;
        double average;

        sum = tanaka + yamada + satoh;
        average = sum / 3.0;
        Console.WriteLine("合計は{0}点で、平均は{1:##.#}点です", sum, average);
    }
}