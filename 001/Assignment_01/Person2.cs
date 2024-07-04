using System;
namespace ConsoleApp1
{
    public class Program
    {
       public struct Person
               {
                   public string Name { get; set; }
                   public int Age { get; set; }
       
                   public Person(string name, int age)
                   {
                       Name = name;
                       Age = age;
                   }
                   
                   
               }
        
        public static int Main(string[] args)
        {

            Person[] p = new Person[3];
            Console.WriteLine("person 1");
            string s = Console.ReadLine();
            int x = Console.Read();
            p[0] = new Person(s, x);
            
            Console.WriteLine("person 2");
            s = Console.ReadLine();
            x = Console.Read();
            p[1] = new Person(s, x);
            
            Console.WriteLine("person 3");
            s = Console.ReadLine();
            x = Console.Read();
            p[2] = new Person(s, x);
            
            Console.WriteLine(p[0].Age>p[1].Age ? (p[0].Age>p[2].Age ? ($"Name {p[0].Name} Age {p[0].Age}") : ($"Name {p[2].Name} Age {p[2].Age}") ) 
                : (p[1].Age>p[2].Age?($"Name {p[1].Name} Age {p[1].Age}") : ($"Name {p[2].Name} Age {p[2].Age}") ) );
            return 0;
        }
    }
}

 
