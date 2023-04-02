using FactoryMethod.Interfaces;

namespace FactoryMethod.Models.Transports;

public class Bike: ITransport
{
    public string GetTransport()
    {
        return "Bike.";
    }
}