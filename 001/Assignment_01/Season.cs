using System;
namespace ConsoleApp1
{
    public class Program
    {
	    public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
	
	public static int Main(string[] args)
        {
		string season = Console.ReadLine();

            Season output;
            if (Enum.TryParse(season, out output))
            {
                switch (output)
                {
                    case Season.Autumn:
                        Console.WriteLine("September to November ");
                        break;
                    case Season.Spring:
                        Console.WriteLine("march to may");
                        break;
                    case Season.Summer:
                        Console.WriteLine("June to august");
                        break;
                    case Season.Winter:
                        Console.WriteLine("December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            return 0;
        }
    }
}


