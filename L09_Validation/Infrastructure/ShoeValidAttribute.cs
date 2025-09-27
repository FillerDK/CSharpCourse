using System.ComponentModel.DataAnnotations;
using L09_Validation.Models;

namespace L09_Validation.Infrastructure;

[AttributeUsage(AttributeTargets.Class)]
public class ShoeValidAttribute : ValidationAttribute
{
    public ShoeValidAttribute()
    {
        ErrorMessage = "Shoe must not be higher than 40 when Silk is used as material!";
    }

    public override bool IsValid(object value)
    {
        var s = (Shoe)value;
        if (s == null) return false;

        return !(s.Material.Equals("Silk") && s.Size > 40);
    }
}