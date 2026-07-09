using Interfaces;

namespace Services;


public class SmsNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"SMS : {message}");
    }
}