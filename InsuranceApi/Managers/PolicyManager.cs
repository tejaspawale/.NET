using InsuranceAPI.Models;
using InsuranceAPI.Delegates;

namespace InsuranceAPI.Managers;

public class PolicyManager
{
    public List<Policy> policies = new List<Policy>();

    public event PolicyDelegate Purchased;

    public void AddPolicy(Policy policy)
    {
        policies.Add(policy);

        Purchased.Invoke("Policy purchased is succesfully");
    }

    public List<Policy> GetAllPolicies()
    {
        return policies;
    }
}