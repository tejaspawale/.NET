
using ActionListener.publishers;
namespace ActionListener.publishers.operation;
public interface TransferManager
{
    void fundTransfer(Account acc1,Account acc2,double amount);
}