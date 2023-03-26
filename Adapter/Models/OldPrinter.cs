namespace Adapter.Models;

public class OldPrinter
{
    public void PrintText(string text)
    {
        Console.WriteLine($"Printing text: {text}");
    }
}