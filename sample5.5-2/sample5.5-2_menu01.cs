// sample5.5-2_menu01.cs

using System;

class Menu01
{
    public static void Main()
    {
        bool bEnd = false;

        while (true) // 無限ループ
        {
            Console.WriteLine("***** Menu *****");
            Console.WriteLine("0:終了");
            Console.WriteLine("1:ファイル");
            Console.WriteLine("2:編集");
            Console.WriteLine("****************");
            Console.Write("選択---- ");

            string strAns = Console.ReadLine();

            switch (strAns)
            {
                case "0":
                    bEnd = true;
                    break;
                case "1":
                    Console.WriteLine("ファイルが選択されました");
                    break;
                case "2":
                    Console.WriteLine("編集が選択されました");
                    break;
                default:
                    Console.WriteLine("入力に間違いがあります");
                    break;
            }

            if (bEnd)
            {
                Console.WriteLine("それでは、このプログラムを終了します");
                break; // この無限ループを脱出
            }
        }
    }
}