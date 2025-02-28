public abstract class LoggerDecorator : ILogger
{
    protected ILogger _logger;

    public LoggerDecorator(ILogger logger)
    {
        _logger = logger;
    }

    public virtual void Log(string message)
    {
        _logger.Log(message);
    }
}