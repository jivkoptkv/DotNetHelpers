using System;

namespace DotNetHelpers.Logging
{
    public class LogPrefixedOutput : AbstractLogOutput
    {
        private const string FORMAT_PREFIX = "[ {0} ] - ";

        private readonly string prefixFormatted;

        public LogPrefixedOutput(string prefix) : base(false)
        {
            this.prefixFormatted = String.Format(FORMAT_PREFIX, prefix);
        }

        public override void WriteLine(string message, params object[] args)
        {
            if (IsActive)
            {
                Log.WriteLine(String.Concat(prefixFormatted, message), args);
            }
        }
    }
}
