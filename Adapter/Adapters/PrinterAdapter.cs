using Adapter.Interfaces;
using Adapter.Models;

namespace Adapter.Adapters;

public class PrinterAdapter : IPrinter
{
    private readonly OldPrinter _oldPrinter;

    public PrinterAdapter(OldPrinter oldPrinter)
    {
        _oldPrinter = oldPrinter;
    }

    public void Print(string text)
    {
        _oldPrinter.PrintText(text);
    }
}