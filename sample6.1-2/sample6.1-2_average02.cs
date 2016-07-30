// sample6.1-2_average02.cs

using System;

class Average02
{
    public static void Main()
    {
        int[] point = { 70, 80, 50 };
        int sum = 0, no;

        no = point.Length;

        for (int i = 0; i < no; i++)
        {
            sum += point[i];
        }

        double average = (double)sum / no;

        Console.WriteLine("合計 = {0},平均 = {1:##.#}", sum, average);
    }
}