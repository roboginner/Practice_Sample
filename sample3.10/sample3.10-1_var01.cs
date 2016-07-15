// sample3.10-1_var01

using System;

class Var01
{
    public static int Main()
    {
        var myText = "猫でもわかるC#プログラミング 第";
        var no = 3;
        var myc = '版';

        Console.WriteLine(myText + no + myc);
        Console.WriteLine(
            "myTextの型は{0}で、noの型は{1}で、mycの型は{2}です",
            myText.GetType(), no.GetType(), myc.GetType());

        return 0;
    }
}