namespace WebApi_s.Logging
{
    public class LogToFile : ILoggers
    {
        public void Log(string message)
        {
            // Code to log the message to a file
            Console.WriteLine($"Logging to file: {message}");
        }
    
    }
}
