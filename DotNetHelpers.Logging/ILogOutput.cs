namespace DotNetHelpers.Logging
{
    public interface ILogOutput
    {
        bool IsActive { get; set; }

        void WriteLine(string message, params object[] args);
    }
}
