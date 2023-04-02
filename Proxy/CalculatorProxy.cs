using Proxy.Interfaces;

namespace Proxy;

public class CalculatorProxy : ICalculator
{
    private readonly Calculator _calculator;

    public CalculatorProxy()
    {
        _calculator = new Calculator();
    }

    public double Calculate(double num1, double num2, char @operator)
    {
        ThrowIfInvalidArgument(num1, num2, @operator);

        return _calculator.Calculate(num1, num2, @operator);
    }
    
    private void ThrowIfInvalidArgument(double num1, double num2, char @operator)
    {
        if (@operator != '+' && @operator != '-' && @operator != '*' && @operator != '/')
        {
            throw new ArgumentException("No such operator exists!");
        }

        if (@operator == '/' && num2 == 0)
        {
            throw new ArgumentException("Zero division error!");

        }
    }
}