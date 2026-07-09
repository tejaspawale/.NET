namespace ProblemStatement;

using Engine;
using UI;
using Notifications;

public class Program
{
    

    public static void Main(string[] args)
    {
        UImanager ui = new UImanager();
        NotificationManager ni = new NotificationManager();
        ui.DisplayMenu();
        ui.notify+=ni.SendEmail;
        while(true){ui.DisplayMenu();
        
        }
    }
}