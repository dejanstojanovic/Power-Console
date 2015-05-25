using System;
using ConsoleExtended;
namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PowerConsole.BeepOnMessageStatus = PowerConsole.MessageStatus.Error;
            PowerConsole.WriteLine("Hello", PowerConsole.MessageStatus.Info);
            PowerConsole.ReadLine<bool>("Enter bool: ",ConsoleColor.Yellow);
        }
    }
}
