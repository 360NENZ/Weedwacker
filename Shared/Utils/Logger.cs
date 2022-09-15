using System;
using System.Diagnostics;
using System.Reflection;

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
            StackTrace stackTrace = new StackTrace();           // get call stack
            StackFrame[] stackFrames = stackTrace.GetFrames();  // get method calls (frames)

            StackFrame callingFrame = stackFrames[1];
            string method = callingFrame.GetMethod().DeclaringType.Name;

            return $"[{DateTime.UtcNow:yy-MM-dd HH:mm:ss}]<{method}> {message}";
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