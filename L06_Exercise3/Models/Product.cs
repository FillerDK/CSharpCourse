namespace L06_Exercise3.Models;

public class Product
{
    public string Title { get; set; }
    
    public decimal Price { get; set; }
    
    public string ImageUrl { get; set; }

    public Product(string title, decimal price)
    {
        Title = title;
        Price = price;
    }

    public Product(string title, decimal price, string imageUrl)
    {
        Title = title;
        Price = price;
        ImageUrl = imageUrl;
    }
}