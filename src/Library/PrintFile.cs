using System.IO;


public class FileStrategy : IPrinterStrategy
{
    public void Print(string content)
    {
        File.WriteAllText("Recipe.txt", content);
    }
}