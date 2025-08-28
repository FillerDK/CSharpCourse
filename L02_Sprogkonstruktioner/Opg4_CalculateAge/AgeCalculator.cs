namespace L02_Sprogkonstruktioner.Opg4_CalculateAge;

public class AgeCalculator
{
    public static void CalculateAge(DateTime BirthDateInput, out int age)
    {
        var yearsOld = DateTime.Now.Year - BirthDateInput.Year;
    
        if (BirthDateInput.Month > DateTime.Now.Month
            || BirthDateInput.Month == DateTime.Now.Month
            && BirthDateInput.Day > DateTime.Now.Day)
        {
            age = yearsOld - 1;
        }
        else
        {
            age = yearsOld;
        }
    } 
}