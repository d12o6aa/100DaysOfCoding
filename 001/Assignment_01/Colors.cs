using System;
namespace ConsoleApp1
{
    public class Program
    {
        public enum Colors
        {
            Red,
            Green,
            Blue
        }
        
        public static int Main(string[] args)
        {
           
            string input = Console.ReadLine();
            Colors color;
            bool x = Enum.TryParse(input, out color);

            if (x)
            {
                Console.WriteLine("It's a primary colour");
            }
            else
            {
                Console.WriteLine("It's NOT a primary colour");
            }
            return 0;
        }
    }
}

