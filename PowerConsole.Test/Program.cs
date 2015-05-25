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
            PowerConsole.BeepOnMessageColor = ConsoleColor.Red;

            PowerConsole.WriteLine("Test", ConsoleColor.Red);
            PowerConsole.ReadLine<bool>("Enter bool: ",ConsoleColor.Yellow);

            Console.ReadLine();
        }
    }
}
