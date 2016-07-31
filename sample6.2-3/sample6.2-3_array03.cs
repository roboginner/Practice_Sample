// sample6.2-3_array03.cs

using System;

class Array03
{
    public static void Main()
    {
        string[,] Name = 
        { 
            { "田中六郎", "吉田一郎", "大田太郎", "粂井康隆", "岡田三郎" }, 
            { "横田芳子", "池田和子", "目黒貴和子", "武田信子", "園田淳子" }
        };

        int myClass, num;
        string strClass, strNum;

        while (true)
        {
            Console.Write("クラスは---");
            strClass = Console.ReadLine();

            if (strClass.Length >= 2)
            {
                Console.WriteLine("入力は一桁のみです");
                continue;
            }

            if (Char.IsNumber(strClass, 0) != true)
            {
                Console.WriteLine("数字を入力してください");
                continue;
            }

            myClass = Int32.Parse(strClass);
            if (myClass <= 0 || myClass >= 3)
            {
                Console.WriteLine("クラスは1組か2組です");
                continue;
            }
            break;
        }
        while (true)
        {
            Console.Write("出席番号は---");
            strNum = Console.ReadLine();

            if (strNum.Length >= 2)
            {
                Console.WriteLine("入力は一桁のみです");
                continue;
            }

            if (Char.IsNumber(strNum, 0) != true)
            {
                Console.WriteLine("数字を入力してください");
                continue;
            }

            num = Int32.Parse(strNum);
            if (num <= 0 || num >= 6){
                Console.WriteLine("出席番号は1番から5番までです");
                continue;
            }
            break;
        }

        Console.WriteLine("{0}クラスの出席番号{1}番は{2}さんです", strClass, strNum, Name[myClass - 1, num - 1]);
    }
}