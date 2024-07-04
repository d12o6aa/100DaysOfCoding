using System;
namespace ConsoleApp1
{
    public enum Gender
    {
        F,
        M
    }
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    
    public class Program
    {
        public static int Main(string[] args)
        {

            HireDate hd1 = new HireDate(1, 12, 2002);
            HireDate hd2 = new HireDate(2, 5, 2032);
            HireDate hd3 = new HireDate(3, 2, 2012);

            Employee[] Arr = new Employee[3];
            Arr[0] = new Employee(1, 60000, Gender.M, SecurityLevel.DBA,  hd1);
            Arr[1] = new Employee(2, 40000, Gender.F, SecurityLevel.Guest, hd2);
            Arr[2] = new Employee(3, 50000, Gender.F, SecurityLevel.Secretary, hd3);
            
            foreach (var emp in Arr)
            {
                Console.WriteLine(emp.ToString());
            }
            return (0);
        }
    }
}

 
