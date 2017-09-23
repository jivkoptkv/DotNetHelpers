namespace DotNetHelpers.Logging
{
    public interface ILogOutput
    {
        void WriteLine(string message, params object[] args);
    }
}
