using Builder.Builders;
using Builder.Builders.Interfaces;
using Builder.Models;

Console.WriteLine("   Starting project\n");

IComputerBuilder topComputerBuilder = new TopComputerBuilder();
Director topDirector = new Director(topComputerBuilder);
topDirector.ConstructComputer();
Computer topComputer = topComputerBuilder.GetComputer();
Console.WriteLine("   Top computer:");
topComputer.Display();

IComputerBuilder mediumComputerBuilder = new MediumComputerBuilder();
Director mediumDirector = new Director(mediumComputerBuilder);
mediumDirector.ConstructComputer();
Computer mediumComputer = mediumComputerBuilder.GetComputer();
Console.WriteLine("\n   Medium computer:");
mediumComputer.Display();

Console.WriteLine("\n   End project");
