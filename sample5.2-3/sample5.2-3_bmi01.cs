// sample5.2-3_bmi01.cs

using System;

class BMI01
{
    public static void Main()
    {
        Console.Write("身長(cm)---");
        string stBl = Console.ReadLine();
        double bl = Convert.ToDouble(stBl);

        Console.Write("体重(kg)---");
        string stBw = Console.ReadLine();
        double bw = Convert.ToDouble(stBw);

        double bmi = bw / Math.Pow((bl / 100.0), 2.0);
        Console.WriteLine("BMI = {0:##.#}", bmi);

        if (bmi >= 25.0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("BMIが25以上です!!");
            Console.ForegroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.WriteLine("BMIは25未満です");
        }
    }
}