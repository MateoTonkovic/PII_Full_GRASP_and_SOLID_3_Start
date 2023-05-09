using System;


public class ConsolePrinter : IPrinterStrategy
{
    public void Print(string recipe)
    {
        Console.WriteLine(recipe);
    }
}
