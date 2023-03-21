using Proxy.Interfaces;

namespace Proxy;

public class CalculatorProxy : ICalculator
{
    private readonly Calculator _calculator;

    public CalculatorProxy()
    {
        _calculator = new Calculator();
    }

    public double Calculate(double num1, double num2, char op)
    {
        ThrowIfInvalidArgument(num1, num2, op);

        return _calculator.Calculate(num1, num2, op);
    }
    
    private void ThrowIfInvalidArgument(double num1, double num2, char op)
    {
        if (op != '+' && op != '-' && op != '*' && op != '/')
        {
            throw new ArgumentException("No such operator exists!");
        }

        if (op == '/' && num2 == 0)
        {
            throw new ArgumentException("Zero division error!");

        }
    }
}