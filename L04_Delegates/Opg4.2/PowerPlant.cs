using L04.Delegates;

namespace L04.Opg4._2;

public class PowerPlant
{
    private Warning _Warning;
    private static Random rand = new Random();
    
    public void SetWarning(Warning wa)
    {
        _Warning += wa;
    }
    
    public void HeatUp()
    {
        var ranNum = rand.Next(1, 101);
        if (ranNum > 50)
        {
            _Warning.Invoke();
        }
    }
}