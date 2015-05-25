using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExtended
{
    public static partial class PowerConsole
    {
        #region Methods

        /// <summary>
        /// Writes a message with options and wait for the user input
        /// </summary>
        /// <param name="message">Masseg to be written in console output</param>
        /// <param name="color"></param>
        /// <param name="showTime"></param>
        /// <param name="timeFormat"></param>
        /// <returns></returns>
        public static string ReadLine(string message, ConsoleColor color = ConsoleColor.Gray, bool showTime = true, string timeFormat = "yyyy-MM-dd hh:mm:ss.ff")
        {
            WriteLine(message, color, showTime, timeFormat);
            return Console.ReadLine();
        }

        /// <summary>
        /// Writes a message with options and wait for the user input
        /// </summary>
        /// <param name="message">Masseg to be written in console output</param>
        /// <param name="status"></param>
        /// <param name="showTime"></param>
        /// <param name="timeFormat"></param>
        /// <returns></returns>
        public static string ReadLine(string message, MessageStatus status = MessageStatus.Default, bool showTime = true, string timeFormat = "yyyy-MM-dd hh:mm:ss.ff")
        {
            WriteLine(message, GetStatusColor(status), showTime, timeFormat);
            return Console.ReadLine();
        }
        #endregion
    }
}
