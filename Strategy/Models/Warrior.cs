using Strategy.Abstracts;

namespace Strategy.Models;

public class Warrior : Character 
{
    public Warrior(string name) 
    {
        Name = name;
    }

    public override void Move() 
    {
        Console.WriteLine($"{Name} moves quickly");
    }

    public override void Attack() 
    {
        Console.WriteLine($"{Name} attacks with a sword");
    }
}