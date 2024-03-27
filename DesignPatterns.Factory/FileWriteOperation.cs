namespace DesignPatterns.Factory;
using System.IO;

public class FileWriteOperation : IFileOperation
{
    public void Execute(string filePath)
    {
        Console.WriteLine("Please type your text below:");
        string content = Console.ReadLine();
        File.WriteAllText(filePath, content);
        Console.WriteLine("Content written to file.");
    }
}