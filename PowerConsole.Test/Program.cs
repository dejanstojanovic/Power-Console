using System;
namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PowerConsole.BeepOnMessageStatus = MessageStatus.Error;
            PowerConsole.WriteLine("Hello", MessageStatus.Info);
            PowerConsole.ReadLine<bool>("Enter bool: ",ConsoleColor.Yellow);
        }
    }
}
