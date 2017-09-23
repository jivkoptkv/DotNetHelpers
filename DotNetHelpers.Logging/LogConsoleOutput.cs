using System;

namespace DotNetHelpers.Logging
{
    public class LogConsoleOutput : AbstractLogOutput
    {
        public LogConsoleOutput() : base(true)
        {
        }

        public override void WriteLine(string message, params object[] args)
        {
            if (IsActive)
            {
                Console.WriteLine(message, args);
            }
        }
    }
}
