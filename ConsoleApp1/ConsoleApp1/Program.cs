using OOP;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Bekzod", "Akhmadov", new DateOnly(2002, 10, 26));
            var person2 = new Person("Asiljon", "Akmaljonov", new DateOnly(2000, 12, 30));

            person1.Pets.Add(new Dog("Hatiko"));
            person1.Pets.Add(new Cat("Kisa"));

            person2.Pets.Add(new Dog("Simba"));
            person2.Pets.Add(new Cat("Mosh"));

            List<Person> people = [person1, person2];

            foreach (var person in people)
            {
                Console.WriteLine($"{person}");
                foreach (var pet in person.Pets)
                {
                    Console.WriteLine($"{pet}");
                }
            }

        }

    }
}
