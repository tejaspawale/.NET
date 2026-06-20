namespace AccountsManager.services;

public class EmailService : NotificationService 
{
    public  void send(String message) {
        Console.WriteLine("Email: "+ message);
    } 
}
