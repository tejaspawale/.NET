namespace  Engine;
using Handlers;

public class MathEngine
{       
    
      public static double Add(double a, double b)
    {
        return a+b;
    }

    public static double Subtract(double a, double b)
    {
        return a-b;
    }

    public static double Multiplication(double a, double b)
    {
        return a*b;
    }

    public static double Division(double a,double b)
    {
        return a/b;
    }

    public MatheOperation mathAdd = new MatheOperation(Add);
    public MatheOperation mathSubtract = new MatheOperation(Subtract);
    public MatheOperation mathMultiplication = new MatheOperation(Multiplication);
    public MatheOperation mathDivision = new MatheOperation(Division);
}