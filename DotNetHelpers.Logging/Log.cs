using System.Collections.Generic;

namespace DotNetHelpers.Logging
{
    public static class Log
    {
        private static readonly IDictionary<string, ILogOutput> prefixedLogs = new Dictionary<string, ILogOutput>();
        private static readonly object prefixedLogsLock = new object();
        private static readonly object outLock = new object();
        private static ILogOutput output = new LogConsoleOutput();

        public static void WriteLine(string message, params object[] args)
        {
            lock (outLock)
            {
                output.WriteLine(message, args);
            }
        }

        public static ILogOutput GetPrefixed(string prefix)
        {
            lock (prefixedLogsLock)
            {
                if (!prefixedLogs.Keys.Contains(prefix))
                {
                    prefixedLogs.Add(prefix, new LogPrefixedOutput(prefix));
                }

                return prefixedLogs[prefix];
            }
        }
    }
}
