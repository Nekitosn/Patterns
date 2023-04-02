using FactoryMethod.Factories;
using FactoryMethod.Factories.Enums;
using FactoryMethod.Interfaces;

Console.WriteLine("   App: Launched with the Taxi type.");
MoveToWork(TransportCreator.ProduceTransport(TransportType.Taxi));

Console.WriteLine("\n   App: Launched with the Bike type.");
MoveToWork(TransportCreator.ProduceTransport(TransportType.Bike));

Console.WriteLine("\n   App: Launched with the Helicopter type.");
MoveToWork(TransportCreator.ProduceTransport(TransportType.Helicopter));


void MoveToWork(ITransport creator)
{
    Console.WriteLine("Today I move to work on " + creator.GetTransport());
}