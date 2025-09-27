using System.ComponentModel.DataAnnotations;
using L09_Validation.Infrastructure;

namespace L09_Validation.Models;

[ShoeValid]
public class Shoe
{
    [Required(ErrorMessage = "You need to specify the shoe size!")]
    [Range(typeof(int), "5", "50", ErrorMessage = "Size of shoe must be between {1} and {2}")]
    public int Size { get; set; }
    
    [Required(ErrorMessage = "You need to specify the shoe material!")]
    [StringLength(40, MinimumLength = 4, ErrorMessage = "Name must be between 4 and {1} characters")]
    public string Material { get; set; }
    
    [Required(ErrorMessage = "You need to specify the production date!")]
    [ProductionDateCheck(ErrorMessage = "You can only start production on a weekday (monday-friday)!")]
    public DateTime ProductionDate { get; set; }
}
