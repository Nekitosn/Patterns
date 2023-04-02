using Adapter.Adapters;
using Adapter.Models;

var oldPrinter = new OldPrinter();

var adapter = new PrinterAdapter(oldPrinter);

adapter.Print("Hello, World!");