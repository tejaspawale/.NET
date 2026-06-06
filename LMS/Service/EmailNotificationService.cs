using Interface.INotificationService;

namespace Service.EmailNotificationService;

public class EmailNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"EMAIL : {message}");
    }
}