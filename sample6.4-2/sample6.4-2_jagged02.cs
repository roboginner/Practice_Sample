// sample6.4-2_jagged02.cs

using System;

class Jagged02
{
    public static void Main()
    {
        string[][] name = new string[2][];
        name[0] = new string[2] { "田中", "工藤" };
        name[1] = new string[3] { "吉田", "佐藤", "池田" };

        for (int i = 0; i < name[0].Length; i++)
        {
            Console.WriteLine(name[0][i]);
        }

        for (int i = 0; i < name[1].Length; i++)
        {
            Console.WriteLine(name[1][i]);
        }
    }
}