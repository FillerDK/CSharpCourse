namespace L06_Exercise3.Models;

public class MusicCD: Product
{
    public string Artist { get; set; }
    
    public string Label { get; set; }
    
    public short Released { get; set; }

    public List<string> Tracks { get; set; } = [];

    public List<Track> TrackList { get; set; } = [];

    public MusicCD(string artist, string title, decimal price, short released) : base(title, price)
    {
        Artist = artist;
        Released = released;
    }
    
    public MusicCD(string title, decimal price, string imageUrl,
        string artist, string label, short released):
        base(title, price, imageUrl)
    {
        Artist = artist;
        Label = label;
        Released = released;
    }

    public void AddTrack(string track)
    {
        Tracks.Add(track);
    }

    public void AddTrack(Track track)
    {
        TrackList.Add(track);
    }

    public TimeSpan GetPlayingTime()
    {
        var total = new TimeSpan(0, 0, 0, 0);

        foreach (var t in TrackList)
        {
            var ts = TimeSpan.ParseExact(t.Length, "m\\:ss", null);
            total = total.Add(ts);
        }
        
        return total;
    }
}