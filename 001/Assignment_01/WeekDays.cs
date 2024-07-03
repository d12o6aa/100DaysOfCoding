namespace ConsoleApp1
{
    public class ConsoleApp1
    {
        public enum WeekDays
        {
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat,
            Sun
        }

        public static int Main()
        {
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            return 0;
        }
    }
}
