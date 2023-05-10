using System.IO;


public class FilePrinter : IPrinterStrategy
{
    public void Print(string content)
    {
        File.WriteAllText("Recipe.txt", content);
    }
}