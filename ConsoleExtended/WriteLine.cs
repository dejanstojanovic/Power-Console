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

        public static void WriteLine(string message, ConsoleColor color = ConsoleColor.Gray, bool showTime = true, string timeFormat = "yyyy-MM-dd hh:mm:ss.ff")
        {
         
            if (showTime)
            {
                message = string.Format("{0} {1}", DateTime.Now.ToString(timeFormat), message);
            }
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            if (color == beepOnMessageColor)
            {
                Console.Beep();
            }
            Console.ForegroundColor = defaultStatusColor;
        }

        public static void WriteLine(string message, MessageStatus status = MessageStatus.Default, bool showTime = true, string timeFormat = "yyyy-MM-dd hh:mm:ss.ff")
        {
            ConsoleColor color = GetStatusColor(status);
            
            WriteLine(message,color , showTime, timeFormat);

        }
    }
}
