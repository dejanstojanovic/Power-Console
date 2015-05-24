using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExtended
{
    public static partial class PowerConsole
    {
        #region Enums

        public enum MessageStatus
        {
            Default = 0,
            Error = 1,
            Warning = 2,
            Info = 3
        }

        #endregion

        #region Fields
        private static ConsoleColor defaultStatusColor = ConsoleColor.Gray;
        private static ConsoleColor errorStatusColor = ConsoleColor.Red;
        private static ConsoleColor warningStatusColor = ConsoleColor.Yellow;
        private static ConsoleColor infoStatusColor = ConsoleColor.White;
        #endregion

        #region Properties
        public static ConsoleColor DefaultStatusColor
        {
            get
            {
                return defaultStatusColor;
            }
            set
            {
                defaultStatusColor = value;
            }
        }
        public static ConsoleColor ErrorStatusColor
        {
            get
            {
                return errorStatusColor;
            }
            set
            {
                errorStatusColor = value;
            }
        }
        public static ConsoleColor WarningStatusColor
        {
            get
            {
                return warningStatusColor;
            }
            set
            {
                warningStatusColor = value;
            }
        }
        public static ConsoleColor InfoStatusColor
        {
            get
            {
                return infoStatusColor;
            }
            set
            {
                infoStatusColor = value;
            }
        }
        #endregion

        #region Methods
        private static ConsoleColor GetStatusColor(MessageStatus status)
        {
            switch (status){
                case MessageStatus.Default:
                    return defaultStatusColor;
                case MessageStatus.Error:
                    return errorStatusColor;
                case MessageStatus.Warning:
                    return warningStatusColor;
                case MessageStatus.Info:
                    return infoStatusColor;
                default:
                    return defaultStatusColor;
            }
        }
        #endregion

    }
}
