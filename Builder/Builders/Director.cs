using Builder.Builders.Interfaces;

namespace Builder.Builders;

public class Director
{
    private IComputerBuilder _computerBuilder;
    
    public Director(IComputerBuilder computerBuilder)
    {
        _computerBuilder = computerBuilder;
    }
    
    public void ConstructComputer()
    {
        _computerBuilder.BuildMemory();
        _computerBuilder.BuildProcessor();
        _computerBuilder.BuildMotherBoard();
    }
}