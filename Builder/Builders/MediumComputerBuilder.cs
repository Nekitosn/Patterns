using Builder.Builders.Interfaces;
using Builder.Models;

namespace Builder.Builders;

public class MediumComputerBuilder : IComputerBuilder
{
    private Computer _computer = new();

    public MediumComputerBuilder()
    {
        Reset();
    }

    private void Reset()
    {
        _computer = new Computer();
    }

    public void BuildMemory()
    {
        _computer.Memory = "16GB";
    }
    
    public void BuildProcessor()
    {
        _computer.Processor = "AMD Ryzen 5 5600X";
    }
    
    public void BuildMotherBoard()
    {
        _computer.MotherBoard = "GIGABYTE B550M DS3H";
    }
    
    public Computer GetComputer()
    {
        return _computer;
    }
}