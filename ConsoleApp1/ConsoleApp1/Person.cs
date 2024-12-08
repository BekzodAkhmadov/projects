namespace OOP;

public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string First { get; } = firstname;

    public string Last { get; } = lastname;

    public DateOnly Birthday { get; } = birthday;

    public List<Pet> Pets { get; } = new();
     
    public override string ToString()
    {
        return $"Human {First} {Last}";
    }
}
