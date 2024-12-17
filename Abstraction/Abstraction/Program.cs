namespace Abstraction
{


    internal class Program
    {

        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        static void Main(string[] args)
        {
            Season a = Season.Autumn;
            var b = (Season)3;
            Console.WriteLine($"Integeral value of {b} is {(int)b}");
        }
    }
}
