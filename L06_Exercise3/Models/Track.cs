namespace L06_Exercise3.Models;

public class Track
{
    public string Title { get; set; }
    
    public string Composer { get; set; }
    
    public string Length { get; set; }

    public Track(string title, string composer, string length)
    {
        Title = title;
        Composer = composer;
        Length = length;
    }
}