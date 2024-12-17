namespace SchoolHRAdministration;

public class log
{
    public void LogTextToScreen(string text)
    {
        Console.WriteLine($"{DateTime.Now}: {text}");
    }

    public void LogTextToFile(string text)
    {
        using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.text"), true))
        {
            sw.WriteLine($"{DateTime.Now}: {text}");
        }
    }
}
