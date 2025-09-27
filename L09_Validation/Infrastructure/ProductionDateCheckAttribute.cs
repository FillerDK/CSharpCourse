using System.ComponentModel.DataAnnotations;

namespace L09_Validation.Infrastructure;

[AttributeUsage(AttributeTargets.Property)]
public class ProductionDateCheckAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        var val = Convert.ToString(value);
        var x = (int)Convert.ToDateTime(val).DayOfWeek;
        return x is >= 1 and <= 5;
    }
}