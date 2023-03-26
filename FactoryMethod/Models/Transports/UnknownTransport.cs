using FactoryMethod.Interfaces;

namespace FactoryMethod.Models.Transports;

public class UnknownTransport : ITransport
{
    public string GetTransport()
    {
        return "This transport does not exist\n";
    }
}