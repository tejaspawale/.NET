

namespace HR;
public class Employee
{
      //Class Members-------------static varialbles, shared 
     //Data Members --------------nonstatic variables, instance 
      public double basic_sal;
      public double hra; // only class
      public  double da;

      public double pf;

        //Method overloading (function overloading) (static polymorphism)
        public Employee(){
          this.basic_sal=5000;
          this.hra=1200;
          this.da=700;
          this.pf = 1800;
        } 
        public Employee(double bsal, double hra, double da,double pf){
            this.basic_sal=bsal;
            this.hra=hra;
            this.da=da;
            this.pf = pf;
        }

 
        //Method overriding (function overriding) (runtime polymorphism)
        public virtual double CalculateSalary()  //virutal function
        {
            return basic_sal + hra+ da *20;
        }

        public virtual double CalculatePF()
        {
          return pf *12;
        }

        public override  string ToString()
        {
          return $"Employee basicsalary: {basic_sal},hra{hra},da{da}";
        }
}