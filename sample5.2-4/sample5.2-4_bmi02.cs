// sample5.2-4_bmi02

using System;

class BMI02
{
    public static void Main()
    {
        string strShow = "BMIは{0:##.#}で{1}です";

        Console.Write("身長(cm)---");
        string strBl = Console.ReadLine();
        double bl = Double.Parse(strBl);

        Console.Write("体重(kg)---");
        string strBw = Console.ReadLine();
        double bw = Double.Parse(strBw);

        double bmi = bw / Math.Pow((bl / 100.0), 2.0);

        if (bmi < 18.5)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(strShow, bmi, "やせすぎ");
        }
        else if (bmi >= 18.5 && bmi < 25.0)
        {
            Console.WriteLine(strShow, bmi, "適正体重");
        }
        else if (bmi >= 25.0 && bmi < 30.0)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(strShow, bmi, "第1度肥満");
        }
        else if (bmi >= 30.0 && bmi < 35.0)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(strShow, bmi, "第2度肥満");
        }
        else if (bmi >= 35.0 && bmi < 40.0)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(strShow, bmi, "第3度肥満");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(strShow, bmi, "第4度肥満");
        }
        Console.ForegroundColor = ConsoleColor.White;
    }
}
