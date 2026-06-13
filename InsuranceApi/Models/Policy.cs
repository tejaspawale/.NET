namespace InsuranceAPI.Models;

public class Policy
{
      public int Id { get; set; }
        public string? CustomerName { get; set; }
        public string? PolicyType { get; set; }
        public double PremiumAmount { get; set; }
}