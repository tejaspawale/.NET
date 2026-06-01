namespace Entities;

public class Product
{
    private int id;
    private string title;
    private string description;
    private decimal price;
    private int stock;
    private int likes;

    public void SetId(int id)
    {
        this.id = id;
    }

    public int GetId()
    {
        return this.id;
    }

    public void SetTitle(string title)
    {
        this.title = title;
    }

    public string GetTitle()
    {
        return this.title;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public string GetDescription()
    {
        return this.description;
    }

    public void SetPrice(decimal price)
    {
        this.price = price;
    }

    public decimal GetPrice()
    {
        return this.price;
    }

    public void SetStock(int stock)
    {
        this.stock = stock;
    }

    public int GetStock()
    {
        return this.stock;
    }

    public void SetLikes(int likes)
    {
        this.likes = likes;
    }

    public int GetLikes()
    {
        return this.likes;
    }
}