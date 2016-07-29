// sample4.6_convert01.cs

using System;

class Convert01
{
    public static void Main()
    {
        byte a = 10;
        sbyte b;
        ushort c;
        short d;
        uint e;
        int f;
        ulong g;
        long h;
        float i;
        double j;
        decimal k;

        //b = a; //byteをsbyteには変換できない
        b = 10;
        //a = b; //sbyteをbyteには変換できない
        c = a;
        d = a;
        e = a;
        f = a;
        g = a;
        h = a;
        i = a;
        j = a;
        k = a;
    }
}