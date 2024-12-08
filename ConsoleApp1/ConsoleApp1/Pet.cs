using System.Collections.Generic;

namespace OOP;

public abstract class Pet(string firstname)
{
    public string First { get; } = firstname;
    public abstract string MakeNoise();

    public override string ToString()
    {
        return $" {First} and I am a {GetType().Name} and I {MakeNoise}";
    }
}
