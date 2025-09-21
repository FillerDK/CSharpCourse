namespace L06_Exercise3.Models;

public class Book: Product
{
    public string Author { get; set; }
    
    public string Publisher { get; set; }
    
    public short Published { get; set; }
    
    public string ISBN { get; set; }

    public Book(string author, string title, decimal price, short published): base(title, price)
    {
        Author = author;
        Published = published;
    }
    
    public Book(string title, decimal price, string imageUrl,
        string author, string publisher, short published, string isbn):
        base(title, price, imageUrl)
    {
        Author = author;
        Publisher = publisher;
        Published = published;
        ISBN = isbn;
    }
}