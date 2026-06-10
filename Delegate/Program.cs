namespace ProblemStatement;

using Engine;
using UI;

public class Program
{
    

    public static void Main(string[] args)
    {
        UImanager ui = new UImanager();
        ui.DisplayMenu();
        while(true){ui.DisplayMenu();}
    }
}