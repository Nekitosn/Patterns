using FactoryMethod.Interfaces;

namespace FactoryMethod.Models.Transports;

public class Helicopter : ITransport
{
    public string GetTransport()
    {
        return "Helicopter.";
    }
}