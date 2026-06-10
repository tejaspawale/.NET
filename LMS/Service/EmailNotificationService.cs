using Interfaces;

namespace Servicess;

public class EmailNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"EMAIL : {message}");
    }
}