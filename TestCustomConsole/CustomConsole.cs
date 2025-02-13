using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomConsole;
//using Console = CustomConsole._Console;
namespace TestCustomConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _Console.WriteLine("Examples");
            _Console.WriteLine();

            _Console.WriteLine("Example: default colors");
            _Console.WriteLine("Red           ", _Console.Color.Red);
            _Console.WriteLine("Green         ", _Console.Color.Green);
            _Console.WriteLine("Gray          ", _Console.Color.Gray);
            _Console.WriteLine("Blue          ", _Console.Color.Blue);
            _Console.WriteLine("Yellow        ", _Console.Color.Yellow);
            _Console.WriteLine("Cyan          ", _Console.Color.Cyan);
            _Console.WriteLine("Magenta       ", _Console.Color.Magenta);
            _Console.WriteLine("White         ", _Console.Color.White);
            _Console.WriteLine("Black         ", _Console.Color.Black);
            _Console.WriteLine();

            _Console.WriteLine("Example: named colors");
            _Console.WriteLine("TextMuted     ", _Console.Color.TextMuted);
            _Console.WriteLine("TextInfo      ", _Console.Color.TextInfo);
            _Console.WriteLine("TextDebug     ", _Console.Color.TextDebug);
            _Console.WriteLine("TextSuccess   ", _Console.Color.TextSuccess);
            _Console.WriteLine("TextWarning   ", _Console.Color.TextWarning);
            _Console.WriteLine("TextDanger    ", _Console.Color.TextDanger);
            _Console.WriteLine();

            _Console.WriteLine("Example: color with background");
            _Console.WriteLine("BgMuted       ", _Console.Color.BgMuted);
            _Console.WriteLine("BgInfo        ", _Console.Color.BgInfo);
            _Console.WriteLine("BgDebug       ", _Console.Color.BgDebug);
            _Console.WriteLine("BgSuccess     ", _Console.Color.BgSuccess);
            _Console.WriteLine("BgWarning     ", _Console.Color.BgWarning);
            _Console.WriteLine("BgDanger      ", _Console.Color.BgDanger);
            _Console.WriteLine();

            _Console.WriteLine("Example: inline colors");
            _Console.Write("TextSuccess   ", _Console.Color.TextSuccess);
            _Console.WriteLine("BgSuccess  ", _Console.Color.BgSuccess);
            _Console.Write("TextDanger    ", _Console.Color.TextDanger);
            _Console.WriteLine("BgDanger   ", _Console.Color.BgDanger);

            _Console.WriteLine();
            _Console.WriteLine("end");

            _Console.ReadLine();
        }
    }
}
