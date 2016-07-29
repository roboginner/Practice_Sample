// sample5.7_continue01.cs

using System;

class Continue01
{
    public static void Main()
    {
        int sum = 0;

        for (int i = 0; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
            else
            {
                continue;
            }
            // iが奇数の場合、continueされるので次の行は表示されない
            Console.WriteLine("i = {0, 2}, sum = {1, 4}", i, sum);
        }
        Console.WriteLine("合計は{0}です", sum);
    }
}