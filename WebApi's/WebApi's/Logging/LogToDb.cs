namespace WebApi_s.Logging
{
    public class LogToDb : ILoggers
    {
        public void Log(string message)
        {
            // Code to log the message to a database
            Console.WriteLine($"Logging to database: {message}");
        }
    
    }
}
