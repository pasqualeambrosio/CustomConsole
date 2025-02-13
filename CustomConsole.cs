using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomConsole
{
    public static class _Console
    {
        #region Most used Console methods
        public static int Read() { return Console.Read(); }
        public static string ReadLine() { return Console.ReadLine(); }
        public static void Clear() { Console.Clear(); }
        public static void ResetColor() { Console.ResetColor(); }
        #endregion

        public enum Color
        {
            // Defaults
            Red,
            Green,
            Gray,
            Blue,
            Yellow,
            Cyan,
            Magenta,
            White,
            Black,

            // Named
            TextMuted,
            TextInfo,
            TextDebug,
            TextSuccess,
            TextWarning,
            TextDanger,

            // With Backgrond
            BgMuted,
            BgInfo,
            BgDebug,
            BgSuccess,
            BgWarning,
            BgDanger
        }

        public static void WriteLine(string text = "", Color color = Color.Gray)
        {
            _Write(text, true, color);
        }

        public static void Write(string text = "", Color color = Color.Gray)
        {
            _Write(text, false, color);
        }        

        private static void _Write(string text = "", bool returnCarriage = true, Color color = Color.Gray)
        {
            Console.ForegroundColor = GetColor(color)[0];
            Console.BackgroundColor = GetColor(color)[1];
            Console.Write(text);
            Console.ResetColor();

            if (returnCarriage)
                Console.WriteLine();
        }

        private static ConsoleColor[] GetColor(Color color)
        {
            switch (color)
            {
                case Color.Red: return new[] { ConsoleColor.Red, ConsoleColor.Black };
                case Color.Green: return new[] { ConsoleColor.Green, ConsoleColor.Black };
                case Color.Gray: return new[] { ConsoleColor.Gray, ConsoleColor.Black };
                case Color.Blue: return new[] { ConsoleColor.Blue, ConsoleColor.Black };
                case Color.Yellow: return new[] { ConsoleColor.Yellow, ConsoleColor.Black };
                case Color.Cyan: return new[] { ConsoleColor.Cyan, ConsoleColor.Black };
                case Color.Magenta: return new[] { ConsoleColor.Magenta, ConsoleColor.Black };
                case Color.White: return new[] { ConsoleColor.White, ConsoleColor.Black };
                case Color.Black: return new[] { ConsoleColor.Black, ConsoleColor.Black };

                case Color.TextMuted: return new[] { ConsoleColor.DarkGray, ConsoleColor.Black };
                case Color.TextInfo: return new[] { ConsoleColor.Cyan, ConsoleColor.Black };
                case Color.TextDebug: return new[] { ConsoleColor.Gray, ConsoleColor.Black };
                case Color.TextSuccess: return new[] { ConsoleColor.Green, ConsoleColor.Black };
                case Color.TextWarning: return new[] { ConsoleColor.Yellow, ConsoleColor.Black };
                case Color.TextDanger: return new[] { ConsoleColor.Red, ConsoleColor.Black };

                case Color.BgMuted: return new[] { ConsoleColor.White, ConsoleColor.Gray };
                case Color.BgInfo: return new[] { ConsoleColor.White, ConsoleColor.Cyan };
                case Color.BgDebug: return new[] { ConsoleColor.DarkGray, ConsoleColor.Gray };
                case Color.BgSuccess: return new[] { ConsoleColor.White, ConsoleColor.Green };
                case Color.BgWarning: return new[] { ConsoleColor.Black, ConsoleColor.Yellow };
                case Color.BgDanger: return new[] { ConsoleColor.White, ConsoleColor.Red };

                default: return new[] { ConsoleColor.Gray, ConsoleColor.Black };
            }
        }
    }
}