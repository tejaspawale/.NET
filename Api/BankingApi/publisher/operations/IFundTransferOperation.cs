using AccountsManager.Models;

namespace AccountsManager.publisher.operations;
public interface IFundTransferOperation {
    public bool FundTransfer(double fromAccout,double ToAccount,double amount);
    
}
