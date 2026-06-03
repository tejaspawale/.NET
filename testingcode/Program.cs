using System;

class Program
{
    static void PrintNames(params string[] names)
    {
        foreach(string name in names)
        {
            Console.WriteLine(name);
        }
    }

    static void Main()
    {
        PrintNames("Tejas");
        PrintNames("Tejas", "Amit");
        PrintNames("Tejas", "Amit", "Rahul");
    }
}