namespace Departement;
using Handlers;
using IPM;



public class SalesDepartment
{
    public void OnPolicyPurchased()
    {
        Console.WriteLine("Sales team notified.");
        PolicyPurchased.Invoke();
        Console.Writ
    }
}
