using System.IO;

public class FileLoggers : ILogger
{
    private string filePath = "log.txt";

    public void Log(string message)
    {
        File.AppendAllText(filePath, message + Environment.NewLine);
        Console.WriteLine($"FileLogger: {message}"); // Display in console as well
    }
}