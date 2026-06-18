
using MaxNewYorkInsurance.Agents;
using MaxNewYorkInsurance.Models;

namespace MaxNewYorkInsurance.Managers;



public class RenewalManager
{
    public event RenewalAgent? policyRenewed;
    public event RenewalAgent? renewalReminderSent;
    public event RenewalAgent? renewalExpired;

    public void RenewPolicy(Policy policy)
        => policyRenewed?.Invoke(policy);

    public void SendRenewalReminder(Policy policy)
        => renewalReminderSent?.Invoke(policy);

    public void ExpirePolicy(Policy policy)
        => renewalExpired?.Invoke(policy);
}