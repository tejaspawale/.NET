using AccountsManager.Models;
using System.Text.Json;

namespace AccountsManager.repository;

public class OperationsRepository
{
    
    public List<Operations> GetAllOperations()
    {
        string fileName = @"C:\TAP\MygitRepo\.NET\accountsmanagerCS\accountsmanagerCS\data\operations.json";
        string jsonString = File.ReadAllText(fileName);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        List<Operations>? Operationss = JsonSerializer.Deserialize<List<Operations>>(jsonString, options);
        return Operationss;
    }

    public bool SaveAllOperations(List<Operations> Operationss)
    {
        bool status = false;
        string fileName = @"C:\TAP\MygitRepo\.NET\accountsmanagerCS\accountsmanagerCS\data\operations.json";
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        string jsonString = JsonSerializer.Serialize(Operationss, options);
        File.WriteAllText(fileName, jsonString);
        status = true;
        return status;
    }
}