// sample3.6-2_type07.cs

using System;

class Type07
{
    public static void Main()
    {
        decimal total;

        Console.Write("借入金額---");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("利息(%)---");
        decimal p = decimal.Parse(Console.ReadLine());

        decimal r = p / 100M;

        total = a * (1m + r);

        Console.WriteLine("1期間後の元利合計は{0:c}です", total);

        a = total;
        total = a * (1m + r);
        Console.WriteLine("2期間後の元利合計は{0:c}です", total);

        a = total;
        total = a * (1m + r);
        Console.WriteLine("3期間後の元利合計は{0:c}です", total);

        a = total;
        total = a * (1m + r);
        Console.WriteLine("4期間後の元利合計は{0:c}です", total);
    }
}