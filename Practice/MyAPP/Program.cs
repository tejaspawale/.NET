using System;

namespace HelloWorld
{
  class Program
  {
  	 public string? Name ;

    public void SetName(string name)
    {
         this.Name = name;
    }

    public string GetName()
        {
            return Name;
        }
    
    
    static void Main(string[] args)
    {
          Program p1 = new Program();
          p1.Name = "Tejas";
          Console.WriteLine(p1.GetName());

          p1.SetName("Sahil");

          Console.WriteLine(p1.GetName());
          
         
    }
  }
}