namespace MaxNewYorkInsurance.Managers;

using System.Drawing;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;
using MaxNewYorkInsurance.Actions;
using MaxNewYorkInsurance.Models;
using Microsoft.AspNetCore.Routing.Constraints;

public class InsurancePolicyManager
{
    //evnets
    public event InsuranceAction policyPurchased;
    public event InsuranceAction claimRegistered;
    public event InsuranceAction premiumPaid;
    public event InsuranceAction policyRenewed;

    public void  PurchasePolicy(Policy policy)
    {
        Console.WriteLine(policy.CustomerName + "" + policy.PolicyType);
        List<Policy> policies=GetAllPolicies();
        policies.Add(policy);
        this.SaveAllPolicies(policies);
        policyPurchased.Invoke(); 
       

    }
    public void RegisterClaim()
    {
        claimRegistered.Invoke();
        Console.WriteLine("Claim Registered Successfully");
    }

    public void  RenewPolicy()
    {
        policyRenewed.Invoke();
        Console.WriteLine(" Existing Policy renewed Successfully");
    }
      public void  PayPremium(Claim claim)
    {
         List<Claim> claims =GetAllPremimum();
        claims.Add(claim);
        this.SaveAllPremium(claims);
        policyPurchased.Invoke(); 
        premiumPaid.Invoke();
        Console.WriteLine("Premium is paid Successfully");
    }

    public List<Policy> GetAllPolicies()
    {
        string fileName=@"C:\TAP\MygitRepo\.NET\InsuranceRestAPIApp\InsuranceRestAPIApp\Data\policies.json";
        string jsonString=File.ReadAllText(fileName);
        var options = new JsonSerializerOptions{ PropertyNameCaseInsensitive = true};
        List<Policy>? policies =JsonSerializer.Deserialize<List<Policy>>(jsonString,options);
        return   policies;
    }


    public bool  SaveAllPolicies(List<Policy> policies)
    {
        bool status=false;
        string fileName=@"C:\TAP\MygitRepo\.NET\InsuranceRestAPIApp\InsuranceRestAPIApp\Data\policies.json";
        var options = new JsonSerializerOptions{ PropertyNameCaseInsensitive = true};
        string jsonString=JsonSerializer.Serialize(policies,options);
        File.WriteAllText(fileName, jsonString);
        status=true;
        return status;
    }

      public List<Claim> GetAllPremimum()
    {
        string fileName=@"C:\TAP\MygitRepo\.NET\InsuranceRestAPIApp\InsuranceRestAPIApp\Data\claim.json";
        string jsonString=File.ReadAllText(fileName);
        var options = new JsonSerializerOptions{ PropertyNameCaseInsensitive = true};
        List<Claim>? claims =JsonSerializer.Deserialize<List<Claim>>(jsonString,options);
        return   claims;
    }


    public bool  SaveAllPremium(List<Claim> claims)
    {
        bool status=false;
        string fileName=@"C:\TAP\MygitRepo\.NET\InsuranceRestAPIApp\InsuranceRestAPIApp\Data\claim.json";
        var options = new JsonSerializerOptions{ PropertyNameCaseInsensitive = true};
        string jsonString=JsonSerializer.Serialize(claims,options);
        File.WriteAllText(fileName, jsonString);
        status=true;
        return status;
    }
}