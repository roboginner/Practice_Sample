// sample6.2-2_array02.cs

using System;

class Array02
{
    public static void Main()
    {
        int[,] myArray = { { 1, 2, 3 }, { 4, 5, 6 } };

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("myArray[{0}, {1}] = {2}", i, j, myArray[i,j]);
            }
        }
    }
}