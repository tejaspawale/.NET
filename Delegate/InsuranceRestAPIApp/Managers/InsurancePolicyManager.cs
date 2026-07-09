namespace MaxNewYorkInsurance.Managers;

using System.Drawing;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;
using MaxNewYorkInsurance.Agents;
using MaxNewYorkInsurance.Models;
using MaxNewYorkInsurance.Departments;
using Microsoft.AspNetCore.Routing.Constraints;

public class InsurancePolicyManager
{
    //evnets
 
    public event  AccountsAgent? policyPurchased;
    public event ClaimsAgent? claimRegistered;
    public event PayPremiumAgent? premiumPaid;
    public event RenewalAgent? policyRenewed;

    Policy p =new Policy();
    AccountsDepartment accD = new AccountsDepartment();

    ClaimDepartment claimD = new ClaimDepartment();
    RenewalDepartment  renewD = new RenewalDepartment();

    SalesDepartment salesD = new SalesDepartment();


    public void onPurchasePolicy(Policy policy)
    {   accD.PurchasePolicy( policy);
        policyPurchased?.Invoke(policy);

    }

    public void onRegisterClaim(Claim claim)
    {
        claimD.RegisterClaim(claim);
        claimRegistered?.Invoke(claim);
    }

   public void  onPolicyRenew(string policyNumber)
{

        renewD.RenewPolicy(policyNumber);
        policyRenewed?.Invoke(p);
    
}
 
    public void onPayPremium(Premium premium)
    {
        accD.PayPremiums(premium);
        policyPurchased.Invoke(p);
        premiumPaid.Invoke();
        Console.WriteLine("Premium is paid Successfully");
    }


   


  
}