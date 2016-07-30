// sample6.2-1_array01.cs

using System;

class Array01
{
    public static void Main()
    {
        int[,] myArray = new int[2, 3];
        int i, j;

        myArray[0, 0] = 1;
        myArray[0, 1] = 2;
        myArray[0, 2] = 3;
        myArray[1, 0] = 4;
        myArray[1, 1] = 5;
        myArray[1, 2] = 6;

        for (i = 0; i < 2; i++)
        {
            for (j = 0; j < 3; j++)
            {
                Console.WriteLine("myArray[{0}, {1}] = {2}", i, j, myArray[i, j]);
            }
        }
    }
}