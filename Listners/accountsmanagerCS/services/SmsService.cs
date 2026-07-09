namespace AccountsManager.services;

public class SmsService : NotificationService 
{
    public  void send(String message) {
        Console.WriteLine("Email: "+ message);
    } 
}
