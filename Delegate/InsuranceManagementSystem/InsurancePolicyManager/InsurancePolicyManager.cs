
namespace IPM;

public class InsurancePolicyManager
{
    public event Action PolicyPurchased;
    public event Action PremiumPaid;
    public event Action ClaimRegistered;
    public event Action PolicyRenewed;
}