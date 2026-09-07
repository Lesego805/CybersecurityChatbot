using System;
using System.Threading;

namespace CybersecurityChatbot
{
    /// <summary>
    /// Handles console aesthetics using soft rounded card frames and clean chat bubbles.
    /// </summary>
    public static class UIFormatter
    {
        private const int TypingSpeedMs = 15;
        private const int WindowWidth = 80;

        /// <summary>
        /// Displays the soft rounded banner card at startup.
        /// </summary>
        public static void DisplayHeader()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            string border = new string('─', WindowWidth - 2);

            Console.WriteLine($"╭{border}╮");
            Console.WriteLine($"│{"",-78}│");
            Console.WriteLine($"│{CenterText("🛡️  Cybersecurity Awareness Guide"),-78}│");
            Console.WriteLine($"│{CenterText("Interactive Online Safety Assistant"),-78}│");
            Console.WriteLine($"│{"",-78}│");
            Console.WriteLine($"╰{border}╯");
            Console.ResetColor();
            Console.WriteLine();
        }

        public static void PrintDivider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(new string('─', WindowWidth));
            Console.ResetColor();
            Console.WriteLine();
        }

        /// <summary>
        /// Displays styled chat badges for speech bubbles.
        /// </summary>
        public static void DisplaySpeaker(string speakerName, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            if (speakerName.ToUpper() == "YOU")
            {
                Console.WriteLine("\n 👤 You");
                Console.WriteLine(" ──────");
            }
            else
            {
                Console.WriteLine($"\n 💬 {speakerName}");
                Console.WriteLine(" ───────────");
            }
            Console.ResetColor();
        }

        /// <summary>
        /// Types out messages smoothly with custom colors.
        /// </summary>
        public static void TypeMessage(string message, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.ForegroundColor = color;
            Console.Write(" ");
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(TypingSpeedMs);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void DisplayWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\n ⚠️  {message}");
            Console.ResetColor();
        }

        public static void DisplayError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n ❌ {message}");
            Console.ResetColor();
        }

        private static string CenterText(string text)
        {
            if (string.IsNullOrEmpty(text)) return "";
            int padding = (78 - text.Length) / 2;
            return text.PadLeft(padding + text.Length).PadRight(78);
        }
    }
}
