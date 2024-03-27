namespace DesignPatterns.Factory;

public class FileOperationFactory
{
    public static IFileOperation CreateOperation(string command)
    {
        switch (command)
        {
            case "read":
                return new FileReadOperation();
            case "write":
                return new FileWriteOperation();
            default:
                throw new ArgumentException("Invalid Command");
        }
    }
}