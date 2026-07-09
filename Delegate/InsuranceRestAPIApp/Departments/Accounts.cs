using MaxNewYorkInsurance.Models;
using MaxNewYorkInsurance.Repositories;

namespace MaxNewYorkInsurance.Departments;

public class AccountsDepartment
{
    PayPremiumRepository PayPremium = new PayPremiumRepository();
    public void PurchasePolicy(Policy policy)
    {

        PolicyRepository repo=new PolicyRepository();
        List<Policy> policies = repo.GetAllPolicies();
        policies.Add(policy);
        repo.SaveAllPolicies(policies);
         
        Console.WriteLine("Payment recorded successfully.");
    }


     public void PayPremiums(Premium premium)
    {
        List<Premium> premiums = PayPremium.GetAllPremimum();
        premiums.Add(premium);
        PayPremium.SaveAllPremium(premiums);
        Console.WriteLine("Premium is paid Successfully");
    }
}