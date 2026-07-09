using AccountsManager.Models;

namespace AccountsManager.publisher.operations;

public interface IMiniStatementOperations
{
    List<Operations> GetMiniStatement(int accountNumber);
}


