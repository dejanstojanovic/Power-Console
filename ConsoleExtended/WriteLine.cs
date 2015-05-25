using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExtended
{
    public static partial class PowerConsole
    {
        #region Fields
        private static MessageStatus? beepOnMessageStatus = null;
        private static ConsoleColor? beepOnMessageColor = null;
        #endregion

        #region Properties
        /// <summary>
        /// Status of the message which will produce beep sound when written in console
        /// </summary>
        public static MessageStatus? BeepOnMessageStatus
        {
            get
            {
                return beepOnMessageStatus;
            }
            set
            {
                beepOnMessageStatus = value;
            }
        }

        /// <summary>
        /// Color of the message which will produce beep sound when written in console
        /// </summary>
        public static ConsoleColor? BeepOnMessageColor
        {
            get
            {
                return beepOnMessageColor;
            }
            set
            {
                beepOnMessageColor = value;
            }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Writes the specified string value, followed by the current line terminator,
        /// to the standard output stream.
        /// </summary>
        /// <param name="message">Message to be written to console output</param>
        /// <param name="color">Color of message text</param>
        /// <param name="showTime">Show time when the message was written to console output</param>
        /// <param name="timeFormat">Date and time format of the time written next to message in console output</param>
        public static void WriteLine(string message, ConsoleColor color = ConsoleColor.Gray, bool showTime = true, string timeFormat = "yyyy-MM-dd hh:mm:ss.ff")
        {

            if (showTime)
            {
                message = string.Format("{0} {1}", DateTime.Now.ToString(timeFormat), message);
            }
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            if (color == beepOnMessageColor || (beepOnMessageStatus != null && GetStatusColor(beepOnMessageStatus.Value) == color))
            {
                Console.Beep();
            }
            Console.ForegroundColor = defaultStatusColor;
        }

        /// <summary>
        /// Writes the specified string value, followed by the current line terminator,
        /// to the standard output stream.
        /// </summary>
        /// <param name="message">Message to be written to console output</param>
        /// <param name="status">status of the message to be written to console output</param>
        /// <param name="showTime">Show time when the message was written to console output</param>
        /// <param name="timeFormat">Date and time format of the time written next to message in console output</param>
        public static void WriteLine(string message, MessageStatus status = MessageStatus.Default, bool showTime = true, string timeFormat = "yyyy-MM-dd hh:mm:ss.ff")
        {
            ConsoleColor color = GetStatusColor(status);

            WriteLine(message, color, showTime, timeFormat);

        }
        #endregion
    }
}
