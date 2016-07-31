// sample7.3-3_norrturnvalue.cs

using System;

class Kakeibo
{
    private int total = 0;

    public void Nyukin(int en) // 値を返さない
    {
        total += en;
        Console.WriteLine("{0}円を入金しました", en);
        return;
    }

    public void Shisyutu(int en)
    {
        if (total < en)
        {
            Console.WriteLine("{0}円も支出できません！", en);
            return;
        }
        else
        {
            total -= en;
            Console.WriteLine("{0}円を支出しました", en);
            return;
        }
    }

    public void GetTotal()
    {
        if (total == 0)
        {
            Console.WriteLine("残高はありません");
            return;
        }
        else
        {
            Console.WriteLine("残高は{0}円です", total);
            return;
        }
    }
}

class NorRturnValue
{
    public static void Main()
    {
        Kakeibo k = new Kakeibo();

        k.GetTotal();
        k.Nyukin(1000);
        k.GetTotal();
        k.Nyukin(2000);
        k.GetTotal();
        k.Shisyutu(500);
        k.GetTotal();
        k.Shisyutu(10000);
        k.GetTotal();
    }
}