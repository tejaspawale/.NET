namespace String;

public class Program
{
    public static void Main(string[] args)
    {
        string sentence = "Build Application";
        string[] words = sentence.Split(" ");
      

        for(int i=0; i<words.Length; i++)
        {     string reverseString = " ";
            for(int j = words[i].Length - 1; j>=0; j--)
            {
                reverseString += words[i][j];
            }
            words[i]=reverseString;
        }
        Console.WriteLine(string.Join(" ",words));

    }
}