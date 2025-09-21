namespace L06_Exercises.Models;

public class Person
{
    public string Firstname { get; set; }
    
    public string Lastname { get; set; }

    public string Address { get; set; }

    public string Zip { get; set; }

    public string City { get; set; }

    private List<string> phoneNumbers = [];
    public List<string> PhoneNumbers
    {
        get { return phoneNumbers; }
        set { phoneNumbers = value; }
    }

    private DateTime birthday;
    public DateTime Birthday
    {
        get => birthday;
        set
        {
            var now = DateTime.Now;
            var age = now.Year - value.Year;
            if (now.Month < value.Month ||
                (now.Month == value.Month && now.Day < value.Day))
            {
                age--;
            }
            
            if (age is < 0 or > 120)
            {
                throw new Exception("Age not accepted");
            }
            else
            {
                birthday = value;
            }
        }
    }

    public int Age
    {
        get
        {
            var now = DateTime.Now;
            var age = now.Year - birthday.Year;
            if (now.Month < birthday.Month ||
                (now.Month == birthday.Month && now.Day < birthday.Day))
            {
                age--;
            }

            return age;
        }
    }

    public Person(string firstname, string lastname, string address, string zip, string city)
    {
        Firstname = firstname;
        Lastname = lastname;
        Address = address;
        Zip = zip;
        City = city;
    }

    public void AddPhone(string phone)
    {
        phoneNumbers.Add(phone);
    }
}