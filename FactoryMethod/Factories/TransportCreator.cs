using FactoryMethod.Factories.Enums;
using FactoryMethod.Interfaces;
using FactoryMethod.Models.Transports;

namespace FactoryMethod.Factories;

public static class TransportCreator
{
    public static ITransport ProduceTransport(TransportType transportType)
    {
        return transportType switch
        {
            TransportType.Bike => new Bike(),
            TransportType.Helicopter => new Helicopter(),
            TransportType.Taxi => new Taxi(),
            _ => new UnknownTransport()
        };
    }
}