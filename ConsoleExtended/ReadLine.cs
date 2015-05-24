using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExtended
{
    public static partial class PowerConsole
    {
        public static string ReadLine(string message, ConsoleColor color = ConsoleColor.Gray, bool showTime = true, string timeFormat = "yyyy-MM-dd hh:mm:ss.ff")
        {
            WriteLine(message, color, showTime, timeFormat);
            return Console.ReadLine();
        }

        public static string ReadLine(string message, MessageStatus status = MessageStatus.Default, bool showTime = true, string timeFormat = "yyyy-MM-dd hh:mm:ss.ff")
        {
            WriteLine(message, GetStatusColor(status), showTime, timeFormat);
            return Console.ReadLine();
        }

    }
}
