namespace User;

     
     public class Employee : Person, IWorker, IPresenter
    {
        public string Position { get; set; }
        public int Salary {get; set;}
        public string Insurance {get; set;}

        public Employee(string n, int a, string p,int salary,string insurance) : base(n, a)
        {
            Position = p;
            Salary = salary;
            Insurance = insurance;

        }

        public void Work()
        {
            System.Console.WriteLine($"{Name} is working as a {Position}.");
        }

        public void Present()
        {
            System.Console.WriteLine($"Hello, I am {Name}, a {Position}.");
        }

        public int Inhandsalary()
    {   
            int pf =  1800*12;

        return Salary -pf;
    }

    public int MonthlySalary()
    {
       int Month= Inhandsalary()/12;

        return Month;
    }

    public int CalculateBonus()
    {
        if (Salary >= 1000000)
        {
            return 50000;
        }
        else if(Salary >=500000)
        {
            return 25000;
        }
        else
        {
            return 10000;
        }
    }
}
