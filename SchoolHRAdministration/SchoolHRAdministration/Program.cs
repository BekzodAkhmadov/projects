namespace SchoolHRAdministration
{
    delegate void LogDel(string text);
    public class Program
    {
        static void Main(string[] args)
        {
            log log = new log();
            LogDel logDel = new LogDel(log.LogTextToFile );

            Console.Write("Please enter your name:");
            var name = Console.ReadLine();

            logDel(name);
            Console.ReadKey();
        }

    }
}
