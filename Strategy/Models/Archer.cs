using Strategy.Abstracts;

namespace Strategy.Models;

public class Archer : Character 
{
    public Archer(string name) 
    {
        Name = name;
    }

    public override void Move() 
    {
        Console.WriteLine($"{Name} moves quickly and silently");
    }

    public override void Attack() 
    {
        Console.WriteLine($"{Name} attacks with a bow");
    }
}