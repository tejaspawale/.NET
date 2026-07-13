namespace strings;

public class Program
{
    public static void Main(string[] args)
    {
        string str = "Anish adak";
        string revStr = "";

        for(int i=str.Length-1; i>=0; i--)
        {
            revStr += str[i];
            
        }
        Console.WriteLine(revStr);

    }
}