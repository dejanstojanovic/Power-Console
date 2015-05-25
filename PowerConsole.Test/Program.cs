using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleExtended;


namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PowerConsole.BeepOnMessageStatus = PowerConsole.MessageStatus.Error;

            PowerConsole.WriteLine("Test", ConsoleColor.Green);
            PowerConsole.ReadLine<bool>("Enter bool: ",ConsoleColor.Yellow);

            
            Console.ReadLine();
        }
    }
}
