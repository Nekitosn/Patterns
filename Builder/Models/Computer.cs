namespace Builder.Models;

public class Computer
{
    public string Memory { get; set; }
    public string Processor { get; set; }
    public string MotherBoard { get; set; }
    
    public void Display()
    {
        Console.WriteLine($"Memory: {Memory}");
        Console.WriteLine($"Processor: {Processor}");
        Console.WriteLine($"MotherBoard: {MotherBoard}");
    }
}