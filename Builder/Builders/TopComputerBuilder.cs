using Builder.Builders.Interfaces;
using Builder.Models;

namespace Builder.Builders;

public class TopComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();
    
    public TopComputerBuilder()
    {
        Reset();
    }

    private void Reset()
    {
        _computer = new Computer();
    }
    
    public void BuildMemory()
    {
        _computer.Memory = "32GB";
    }
    
    public void BuildProcessor()
    {
        _computer.Processor = "Intel Core i9-11900K";
    }
    
    public void BuildMotherBoard()
    {
        _computer.MotherBoard = "ASUS ROG Maximus XIII Hero";
    }
    
    public Computer GetComputer()
    {
        return _computer;
    }
}