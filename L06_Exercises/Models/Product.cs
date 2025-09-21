using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Product
{
    // Read-only
    private string name; // field
    public string Name // property
    {
        get { return name; }
    }

    private double price; // field
    public double Price // property
    { 
        // 
        set {
            if (value <= 0)
            { 
                throw new Exception("Price is not accepted"); 
            } 
            else { 
                price = value; 
            } 
        } 
        get { return price; } 
    }

    // 11. Auto-property
    public string ImageUrl { get; set; }
    
    // 4. manufacturer field
    private string manufacturer; // field
    // 5. Manufacturer property
    public string Manufacturer // property
    {
        get { return manufacturer; }
        set { manufacturer = value; }
    }

    // constructor 1
    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    // constructor 2
    // 6. manufacturer added as parameter
    public Product(string name, double price, string imageUrl, string manufacturer)
    {
        this.name = name;
        this.price = price;
        ImageUrl = imageUrl;
        this.manufacturer = manufacturer;
    }
}