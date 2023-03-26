using Builder.Models;

namespace Builder.Builders.Interfaces;

public interface IComputerBuilder
{
    public void BuildMemory();
    public void BuildProcessor();
    public void BuildMotherBoard();
    public Computer GetComputer();
}