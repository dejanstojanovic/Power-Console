using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static partial class PowerConsole
    {
        #region Methods

        /// <summary>
        /// Writes a message with options and wait for the user input
        /// </summary>
        /// <param name="message">Message text to be written in console output</param>
        /// <param name="color">Console color to be used to write only tis line of text</param>
        /// <param name="showTime">Show date and time at the begining of line</param>
        /// <param name="timeFormat">Display format for the date and time</param>
        /// <returns>Returns entered value from the user</returns>
        public static string ReadLine(string message, ConsoleColor color = ConsoleColor.Gray, bool showTime = true, string timeFormat = "yyyy-MM-dd hh:mm:ss.ff")
        {
            WriteLine(message, color, showTime, timeFormat);
            return Console.ReadLine();
        }

        /// <summary>
        /// Writes a message with options and wait for the user input
        /// </summary>
        /// <param name="message">Message text to be written in console output</param>
        /// <param name="status">Message status to be used to output message text</param>
        /// <param name="showTime">show date and time at the begining of line</param>
        /// <param name="timeFormat">Display format for the date and time</param>
        /// <returns>Returns entered value from the user</returns>
        public static string ReadLine(string message, MessageStatus status = MessageStatus.Default, bool showTime = true, string timeFormat = "yyyy-MM-dd hh:mm:ss.ff")
        {
            WriteLine(message, GetStatusColor(status), showTime, timeFormat);
            return Console.ReadLine();
        }


        /// <summary>
        /// Writes a message with options and wait for the user input
        /// </summary>
        /// <typeparam name="T">Generic type to validate the input and request for re-entering if eneted value is invalid</typeparam>
        /// <param name="message">Message text to be written in console output</param>
        /// <param name="color">Console color to be used to write only tis line of text</param>
        /// <param name="showTime">Show date and time at the begining of line</param>
        /// <param name="timeFormat">Display format for the date and time</param>
        /// <returns>Returns entered value from the user</returns>
        public static T ReadLine<T>(string message, ConsoleColor color = ConsoleColor.Gray, bool showTime = true, string timeFormat = "yyyy-MM-dd hh:mm:ss.ff") where T : IConvertible
        {
            WriteLine(message,color, showTime, timeFormat);
            string input = Console.ReadLine();
                    try
                    {
                        return (T)Convert.ChangeType(input, typeof(T));
                    }
                    catch (Exception ex)
                    {
                        WriteLine(ex,showTime,timeFormat);
                        return ReadLine<T>(message,color,showTime,timeFormat);
                    }
            }

        /// <summary>
        /// Writes a message with options and wait for the user input
        /// </summary>
        /// <typeparam name="T">Generic type to validate the input and request for re-entering if eneted value is invalid</typeparam>
        /// <param name="message">Message text to be written in console output</param>
        /// <param name="status">Message status to be used to output message text</param>
        /// <param name="showTime">show date and time at the begining of line</param>
        /// <param name="timeFormat">Display format for the date and time</param>
        /// <returns>Returns entered value from the user of type T</returns>
        public static T ReadLine<T>(string message, MessageStatus status = MessageStatus.Default, bool showTime = true, string timeFormat = "yyyy-MM-dd hh:mm:ss.ff") where T : IConvertible
        {
            var color = GetStatusColor(status);
            return ReadLine<T>(message, color, showTime, timeFormat);
        }



        #endregion
    }
}
