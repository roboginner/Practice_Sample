// sample5.4-3_for03.cs

using System;

class For03
{
    public static void Main()
    {
        int i = 0;

        for ( ; ; ) // 無限ループ！！
        {
            Console.WriteLine("i = {0}", i);
            i++;
            if (i >= 5) break; // iが5以上になったらbreak文で脱出
        }
    }
}