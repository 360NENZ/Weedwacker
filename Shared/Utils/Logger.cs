using System;

namespace Weedwacker.Shared.Utils
{
    public static class Logger
    {
        public static void WriteLine(string message)
        {
            Console.WriteLine(ParseMessage(message));
        }
        private static string ParseMessage(string message)
        {
            return $"[{DateTime.UtcNow:yy-MM-dd HH:mm:ss}] {message}";
        }
        public static void DebugWriteLine(string message)
        {
#if DEBUG
            Console.WriteLine(ParseMessage(message));
#endif
        }
        public static void WriteErrorLine(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Error.WriteLine(ParseMessage(message));
            Console.ResetColor();
        }

        public static void WriteErrorLine(string message, Exception e)
        {
            WriteErrorLine(message);
            WriteErrorLine(e.StackTrace);
        }
    }
}