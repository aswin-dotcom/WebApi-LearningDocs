namespace WebApi_s.Logging
{
    public class LogToConsole : ILoggers
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
