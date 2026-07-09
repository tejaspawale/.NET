using cc;

class Program
{
    static void Main()
    {
        Product[] products =
        {
            new Product(101, "Tejas", 500),
            new Product(102, "Rahul", 600),
            new Product(103, "Amit", 700)
        };

        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine(
                $"Id: {products[i].Id}, Name: {products[i].Name}, Price: {products[i].Price}"
            );
        }
    }
}