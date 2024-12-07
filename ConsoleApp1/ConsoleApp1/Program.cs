using OOP;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Bekzod", "Akhmadov", new DateOnly(2002, 10, 26));
            var person2 = new Person("Asiljon", "Akmaljonov", new DateOnly(2000, 12, 30));

            List<Person> peopla = [person1, person2];

        }

    }
}
