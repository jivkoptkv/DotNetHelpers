namespace DotNetHelpers.Logging
{
    public abstract class AbstractLogOutput : ILogOutput
    {
        public bool IsActive { get; set; }

        protected AbstractLogOutput(bool isActive)
        {
            IsActive = isActive;
        }

        public abstract void WriteLine(string message, params object[] args);
    }
}
