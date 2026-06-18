using MaxNewYorkInsurance.Models;
using MaxNewYorkInsurance.Agents;
namespace MaxNewYorkInsurance.Managers;


public class SalesManager
{
   public event AccountsAgent? policyPurchased;
public event SalesAgent? policyQuoted;
public event SalesAgent? policyUpdated;
public event SalesAgent? policyCancelled;
public event SalesAgent? leadGenerated;
public event SalesAgent? discountOffered;


 public void PurchasePolicy(Policy policy)
    {   
        policyPurchased?.Invoke(policy);
    }
}