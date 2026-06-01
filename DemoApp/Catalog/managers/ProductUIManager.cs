using Entities;
namespace managers;

public class ProductUIManager
{
    public Product AcceptProductDetails()
    {
        Product product = new Product();

            Console.WriteLine("Enter Product ID:");
            product.SetId(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter Product Title:");
            product.SetTitle(Console.ReadLine());

            Console.WriteLine("Enter Product Description:");
            product.SetDescription(Console.ReadLine());

            Console.WriteLine("Enter Product Price:");
            product.SetPrice(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("Enter Product Stock:");
            product.SetStock(int.Parse(Console.ReadLine()));
            

            return product;
        
    }

    public void DisplayProductDetails(Product product)
        {
            
            Console.WriteLine("Product Details:");
            Console.WriteLine($"ID: {product.GetId()}");
            Console.WriteLine($"Title: {product.GetTitle()}");
            Console.WriteLine($"Description: {product.GetDescription()}");
            Console.WriteLine($"Price: ${product.GetPrice()}");
            Console.WriteLine($"Stock: {product.GetStock()}");
            Console.WriteLine($"Likes: {product.GetLikes()}");
        }
}

