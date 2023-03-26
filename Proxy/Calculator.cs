using Proxy.Interfaces;

namespace Proxy;

public class Calculator : ICalculator
{
    public double Calculate(double num1, double num2, char @operator)
    {
        switch (@operator)
        {
            case '+': return num1 + num2;
            case '-': return num1 - num2;
            case '*': return num1 * num2;
            case '/': return num1 / num2;
            default: throw new ArgumentException("Неверный оператор");
        }
    }
}