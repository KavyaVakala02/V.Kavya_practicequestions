public class TimestampLogger : LoggerDecorator
{
    public TimestampLogger(ILogger logger) : base(logger) { }

    public override void Log(string message)
    {
        string timestampedMessage = $"[{DateTime.Now}] {message}";
        base.Log(timestampedMessage);
    }
}