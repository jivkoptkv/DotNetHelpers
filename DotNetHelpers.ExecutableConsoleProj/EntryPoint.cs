using DotNetHelpers.Logging;
using System;

namespace DotNetHelpers.ExecutableConsoleProj
{
    internal class EntryPoint
    {
        private static readonly ILogOutput log;

        static EntryPoint()
        {
            log = Log.GetPrefixed("EntryPoint");
        }

        private static void Main(string[] args)
        {
            log.WriteLine("Hi there , its {0} local time here!", DateTime.Now);
            Pause();
        }

        private static void Pause()
        {
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
