using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace L07_HTML_helpers.Models.Exercise02;

public class ParkingTicketMachine
{
    private int minutesPrKr = 3;

    public int[] CoinsToInsert { get; } = [1, 2, 5, 10, 20];
    private int amountInserted;
    private DateTime timeNow;
    
    //[HiddenInput(DisplayValue = false)]
    public int AmountInserted { get => amountInserted; }

    [Display(Name = "Paid until")]
    [DataType(DataType.Time)]
    public DateTime PaidUntil => timeNow.AddMinutes(minutesPrKr * amountInserted);

    [Display(Name = "Time now")]
    [DataType(DataType.Time)]
    public DateTime TimeNow => timeNow;
    
    [Display(Name = "Info display")]
    public string Info { get; set; }

    public ParkingTicketMachine()
    {
        amountInserted = 0;
        timeNow = DateTime.Now;
        Info = "";
    }

    public void insertCoin(int kr)
    {
        amountInserted += kr;
    }
}