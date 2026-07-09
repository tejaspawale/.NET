namespace UI;
using Engine;
using Handlers;
public class UImanager
{
    public  event  Sender?  notify;
    MathEngine mEngine = new MathEngine();
    
    public void DisplayMenu()
    {
        Console.WriteLine("===== Math Engine =====");
        Console.WriteLine(" ");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Exit");
        Console.WriteLine(" ");
        Console.Write("Enter Choice: ");

        int choice = int.Parse(Console.ReadLine());
        HandleInputChoice(choice);

    }

    public void HandleInputChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                    {
                        Console.Write("Enter first number: ");
                        double first = double.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double second = double.Parse(Console.ReadLine());
                        double op = mEngine.mathAdd(first, second);
                        Console.WriteLine($"Result: {op}");
                        notify.Invoke("amount has been deducted from account");
                        
                    }
                    break;

             case 2:
                    {
                        Console.Write("Enter first number: ");
                        double first = double.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double second = double.Parse(Console.ReadLine());
                        double op = mEngine.mathSubtract(first, second);
                        Console.WriteLine($"Result: {op}");
                        
                    }
                    break;


             case 3:
                    {
                        Console.Write("Enter first number: ");
                        double first = double.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double second = double.Parse(Console.ReadLine());
                        double op = mEngine.mathMultiplication(first, second);
                        Console.WriteLine($"Result: {op}");
                        notify.Invoke("amount has been deducted from account");
                        
                    }
                    break;

            case 4:
                    {
                        Console.Write("Enter first number: ");
                        double first = double.Parse(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        double second = double.Parse(Console.ReadLine());
                        double op = mEngine.mathDivision(first, second);
                        Console.WriteLine($"Result: {op}");
                        notify.Invoke("amount has been deducted from account");
                    }
                    break;

            case 5:
            Environment.Exit(0);
            break;

        }
    }
}