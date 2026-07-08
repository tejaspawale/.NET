namespace  TFLcll;

public class Program
{
    public static void Main(string[] args)
    {
        CircularLinklist cll = new CircularLinklist();
        cll.Insert(15);
        cll.Display();
        cll.Insert(20);
        cll.Display();
        cll.Insert(10);
        cll.Display();
        cll.Insert(5);
        cll.Display();
        cll.Update(15,40);
        cll.Display();
        


    }
}
