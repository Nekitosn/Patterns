using FactoryMethod.Interfaces;

namespace FactoryMethod.Models.Transports;

public class Taxi : ITransport
{
    public string GetTransport()
    {
        return "Taxi.";
    }
}