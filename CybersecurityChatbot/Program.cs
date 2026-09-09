using System;

namespace CybersecurityChatbot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enable UTF-8 so emojis and box-drawing characters display correctly
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Set up terminal window size and title
            Console.Title = "Cybersecurity Awareness Assistant";

            // Render Header Banner
            UIFormatter.DisplayHeader();

            // Play voice greeting sound
            AudioPlayer.PlayGreeting("Assets/greeting.wav");

            // Initialize Chat Engine
            ChatEngine engine = new ChatEngine();
            engine.AskUserName();
            
            // Conversation Loop
            bool keepRunning = true;
            while (keepRunning)
            {
                UIFormatter.DisplaySpeaker("You", ConsoleColor.Green);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" ");
                string? input = Console.ReadLine();
                Console.ResetColor();

                keepRunning = engine.ProcessInput(input);
            }
        }
    }
}
