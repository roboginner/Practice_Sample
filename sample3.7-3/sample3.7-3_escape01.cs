// sample3.7-3_escape01

using System;

class Escape01
{
    public static void Main()
    {
        char n = '\n';
        string str1 = "今日は";
        string str2 = "よい天気です";

        Console.WriteLine(str1 + n + str2);

        string str3 = "今日は\\よい天気です";
        Console.WriteLine(str3);
    }
}