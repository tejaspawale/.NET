// using System;
// namespace Name;

// public class ConstReadOnly
// {
//     public const int MaxValue = 10;

//     public readonly int readonly2;

//     public string name;

//     public ConstReadOnly(int r,string n)
//     {   
//         this.readonly2 = r;
//         this.name= n;

//     }

//     public void GetData(int r,string n)
//     {
//         Console.WriteLine($"data {r} name {n}");
//     }

//     public override string ToString()
//     {
//         return $"ConstReadOnly {{name= {name}}}";
        
//     }

//      public static void Main(string[] args)
//     {
//        ConstReadOnly c = new ConstReadOnly(2,"Tejas");
//        Console.WriteLine(c); 
//        c.GetData(2,"Tejas");
//     }


// }