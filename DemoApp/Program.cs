using System;
using Entities;
using managers;

class Program
{
    public static void Main(string [] args)
    {
       ProductUIManager productUIManager = new ProductUIManager();
       Product product = productUIManager.AcceptProductDetails();
       productUIManager.DisplayProductDetails(product);
        

    }
}