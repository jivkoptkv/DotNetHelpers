using System.Collections.Generic;

namespace DotNetHelpers.Logging
{
    public static class Log
    {
        private static readonly IDictionary<string, ILogOutput> prefixedLogs;

        private static readonly object prefixedLogsLock;

        private static readonly object outLock;

        private static ILogOutput output;

        static Log()
        {
            prefixedLogs = new Dictionary<string, ILogOutput>();
            prefixedLogsLock = new object();
            outLock = new object();
            output = new LogConsoleOutput();
        }

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
