namespace Builder.Models;

public class Computer
{
    public string Memory { get; set; }
    public string Processor { get; set; }
    public string MotherBoard { get; set; }

    public override string ToString()
    {
        return 
            $"\nMemory: {Memory}\n" +
            $"Processor: {Processor}\n" +
            $"MotherBoard: {MotherBoard}" ;
    }
}