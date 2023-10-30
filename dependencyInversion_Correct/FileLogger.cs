namespace dependencyInversion_Correct;

public class FileLogger:ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}