using AccountsManager.Models;
using System.Text.Json;

namespace AccountsManager.repository;

public class AccountRepository
{
    
    public List<Account> GetAllAccounts()
    {
        string fileName = @"D:\TFL\new tfl\TFLDOTNET\DotNet\AccountListner in CS\accountsmanagerCS\data\accounts.json";
        string jsonString = File.ReadAllText(fileName);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        List<Account>? accounts = JsonSerializer.Deserialize<List<Account>>(jsonString, options);
        return accounts;
    }

    public bool SaveAllAccounts(List<Account> accounts)
    {
        bool status = false;
        string fileName = @"D:\TFL\new tfl\TFLDOTNET\DotNet\AccountListner in CS\accountsmanagerCS\data\accounts.json";
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        string jsonString = JsonSerializer.Serialize(accounts, options);
        File.WriteAllText(fileName, jsonString);
        status = true;
        return status;
    }
}