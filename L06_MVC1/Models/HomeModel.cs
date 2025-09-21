namespace L06_MVC1.Models;

public class HomeModel
{
    public HomeModel(string name, int age, DateTime birthday)
    {
        Name = name;
        Age = age;
        Birthday = birthday;
    }
    
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime Birthday { get; set; }
}