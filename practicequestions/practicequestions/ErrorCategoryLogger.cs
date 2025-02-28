public class ErrorCategoryLogger : LoggerDecorator
{
    private string _category;

    public ErrorCategoryLogger(ILogger logger, string category) : base(logger)
    {
        _category = category;
    }

    public override void Log(string message)
    {
        string categorizedMessage = $"[{_category.ToUpper()}] {message}";
        base.Log(categorizedMessage);
    }
}