
using MaxNewYorkInsurance.Models;
using System.Text.Json;

namespace MaxNewYorkInsurance.Repositories;

public class CustomerRepository 
{
public List<Customer> GetAllCustomer()
    {
        string fileName = @"C:\TAP\MygitRepo\.NET\InsuranceClaimMaxRestAPIApp\InsuranceRestAPIApp\Data\customer.json";
        string jsonString = File.ReadAllText(fileName);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        List<Customer>? customers = JsonSerializer.Deserialize<List<Customer>>(jsonString, options);
        return customers;
    }


    public bool SaveAllCustomer(List<Customer> customers)
    {
        bool status = false;
        string fileName = @"C:\TAP\MygitRepo\.NET\InsuranceClaimMaxRestAPIApp\InsuranceRestAPIApp\Data\customer.json";
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        string jsonString = JsonSerializer.Serialize(customers, options);
        File.WriteAllText(fileName, jsonString);
        status = true;
        return status;
    }


}