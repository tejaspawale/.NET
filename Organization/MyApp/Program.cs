
using User;
namespace MyApp;

public class Program
{
    public static void Main(string [] args)
    {
    // {
    //     Employee emp = new Employee("Tejas",28,"Intern",1000000,"TIG Health Insurance");
        
    //     IWorker worker = emp;
    //     worker.Work();
    //     Console.WriteLine("After Deduting PF Amount Salary:" +emp.Inhandsalary()+" Rupees.");
    //     Console.WriteLine ("Monthly Salary In Hand After Deduction:" +emp.MonthlySalary()+" Rupees.");
    //     Console.WriteLine("New Joinee Bonus: " + emp.CalculateBonus()+" Rupess.");



    //     Employee emp1 = new Employee("Ravi",28,"Intern",250000,"Axis Health Insurance");
        
    //     IWorker worker1 = emp1;
    //     worker1.Work();
    //     Console.WriteLine("After Deduting PF Amount Salary:" +emp1.Inhandsalary()+" Rupees.");
    //     Console.WriteLine ("Monthly Salary In Hand After Deduction:" +emp1.MonthlySalary()+" Rupees.");
    //     Console.WriteLine("New Joinee Bonus: " + emp1.CalculateBonus()+" Rupess.");


         Employee emp2 = new Employee("Sahil",22,"Software Enginner",800000,"Bajaj Health Insurance");
        
        IWorker worker2 = emp2;
        worker2.Work();
        Console.WriteLine("After Deduting PF Amount Salary:" +emp2.Inhandsalary()+" Rupees.");
        Console.WriteLine ("Monthly Salary In Hand After Deduction:" +emp2.MonthlySalary()+" Rupees.");
        Console.WriteLine("New Joinee Bonus: " + emp2.CalculateBonus()+" Rupess.");

        




    }
}