namespace ConsoleApp1;

public class HireDate
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public HireDate(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Day:D2}/{Month:D2}/{Year}";
    }
}
