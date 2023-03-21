using Proxy;
using Proxy.Interfaces;

ICalculator calculator = new CalculatorProxy();

Console.WriteLine("   Starting");

Console.WriteLine("\n   Check for valid arguments");

Console.WriteLine($"Calculate 5 + 3 = {calculator.Calculate(5, 3, '+')}");
Console.WriteLine($"Calculate 5 - 3 = {calculator.Calculate(5, 3, '-')}");
Console.WriteLine($"Calculate 5 * 3 = {calculator.Calculate(5, 3, '*')}");
Console.WriteLine($"Calculate 5 / 3 = {calculator.Calculate(5, 3, '/')}");

Console.WriteLine("\n   Check for invalid arguments");

Console.Write($"Calculate 5 V 3 = ");
try
{
    Console.WriteLine($"Calculate 5 % 3: {calculator.Calculate(5, 3, 'V')}");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

Console.Write($"Calculate 5 / 0 = ");
try
{
    Console.WriteLine($"Calculate 5 / 0: {calculator.Calculate(5, 0, '/')}");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("\n   End program");

