// sample2.5_readline01.cs

using System;

class ReadLine01
{
    public static void Main()
    {
        string name;
        Console.WriteLine("あなたのお名前は何ですか---");
        name = Console.ReadLine();
        Console.WriteLine("あなたのお名前は{0}とおっしゃるんですね", name);
    }
}