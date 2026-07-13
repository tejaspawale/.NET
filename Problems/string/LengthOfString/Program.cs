namespace StringProblems;

public class Program
{



    public static void Main(string[] args)
    {
        string name = "Tejas";
        int count = 0;
        foreach (var i in name)
        {
            count++;
        }
        Console.WriteLine(count);
    }

}