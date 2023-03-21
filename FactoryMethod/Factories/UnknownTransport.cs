using FactoryMethod.Interfaces;

namespace FactoryMethod.Factories;

public class UnknownTransport : ITransport
{
    public string GetTransport()
    {
        return "This transport does not exist\n";
    }
}