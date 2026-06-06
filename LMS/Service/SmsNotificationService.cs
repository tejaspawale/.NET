using Interface.INotificationService;

namespace Service.SmsNotificationService;


public class SmsNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"SMS : {message}");
    }
}