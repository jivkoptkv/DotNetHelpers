using System;

namespace DotNetHelpers.Logging
{
    public class LogConsoleOutput : ILogOutput
    {
        void ILogOutput.WriteLine(string message, params object[] args)
        {
            Console.WriteLine(message, args);
        }
    }
}
