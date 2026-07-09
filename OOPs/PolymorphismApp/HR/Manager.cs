
namespace HR;
public  class Manager : Employee
{
    private double incentive;
    public Manager()
    {
        this.incentive=0;
    }
     public Manager(double sal, double hra, double da, double incentive,double pf):base(sal,hra,da,pf)
    {
        this.incentive=incentive;
        
    }

    public override  double CalculateSalary()
    {    
        return  base.CalculateSalary() + incentive;
    }

       public override double CalculatePF()
        {
          return base.CalculateSalary() +pf *12 + 2500;
        }


}
