namespace OOP;

public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string Firstname { get; } = firstname;

    public string Lastname { get; } = lastname;

    public DateOnly Birthday { get; } = birthday;
}
