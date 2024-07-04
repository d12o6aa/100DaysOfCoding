
namespace ConsoleApp1
{
    public class Program
    {
        public struct Person
        {
            private string _name;
            private int _age;

            
            public Person(string name, int age)
            {
                _name = name;
                _age = age;
            }

            public string GetName()
            {
                return _name;
            }
            public int GetAge()
            {
                return _age;
            }
            
        }

        public static int Main(string[] args)
        {
            Person[] p = new Person[3];
            p[0] = new Person("doaa", 20);
            p[1] = new Person("alx", 23);
            p[2] = new Person("jo", 19);

            foreach (Person person in p)
            {
                Console.WriteLine($"{person.GetName()} {person.GetAge()}");
            }
            
            
            return 0;
        }
    }
}
