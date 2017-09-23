using System;

namespace DotNetHelpers.Logging
{
    public class LogPrefixedOutput : ILogOutput
    {
        private const string FORMAT_PREFIX = "[ {0} ] - ";

        private readonly string prefixFormatted;

        public LogPrefixedOutput(string prefix)
        {
            this.prefixFormatted = String.Format(FORMAT_PREFIX, prefix);
        }

        public void WriteLine(string message, params object[] args)
        {
            Log.WriteLine(String.Concat(prefixFormatted, message), args);
        }
    }
}
