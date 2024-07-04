using System;
namespace ConsoleApp1
{
    public class Program
    {
       
        public struct Point
        {
            int X;
            int Y;
            public int z { get; set; }

            public Point(int x,int y)
            {
                X = x;
                Y = y;
            }

            public void distance(int x, int y)
            {
                double distance = Math.Sqrt(x + y);
                Console.WriteLine($"The distance is {(int) distance}");
            }
        }
        
        public static int Main(string[] args)
        {

            Console.WriteLine("Enter x1");
            int x1 = Console.Read();
            Console.WriteLine("Enter x2");
            int x2 = Console.Read();
            
            Console.WriteLine("Enter y1");
            int y1 = Console.Read();
            Console.WriteLine("Enter y2");
            int y2 = Console.Read();

            Point point = new Point();
            point.distance(Math.Abs(x1 - x2),Math.Abs(y1 - y2));
            return 0;
        }
    }
}
