namespace L03_Objektorientering.Opg3._4;

public class CprNr
{
    private string birthDate;
    private string sequenceNumber;

    public CprNr(string bDate, string sNumber)
    {
        BirthDate = bDate;
        SequenceNumber = sNumber;
    }
    
    public string BirthDate
    {
        get { return birthDate; }
        set { birthDate = value; }
    }
    
    public string SequenceNumber
    {
        get { return sequenceNumber; }
        set { sequenceNumber = value; }
    }

    public override bool Equals(object? obj)
    {
        if (obj is CprNr other)
        {
            return BirthDate == other.BirthDate && 
                   SequenceNumber == other.SequenceNumber;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(BirthDate, SequenceNumber);
    }
}