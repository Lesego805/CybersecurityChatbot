using System;

namespace CybersecurityChatbot
{
    public class ChatEngine
    {
        public string UserName { get; private set; } = "User";

        public void AskUserName()
        {
            while (true)
            {
                UIFormatter.DisplaySpeaker("Assistant", ConsoleColor.Cyan);
                UIFormatter.TypeMessage("Before we begin, what is your name?", ConsoleColor.White);

                UIFormatter.DisplaySpeaker("You", ConsoleColor.Green);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" ");
                string? input = Console.ReadLine();
                Console.ResetColor();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    UserName = input.Trim();
                    UIFormatter.DisplaySpeaker("Assistant", ConsoleColor.Cyan);
                    UIFormatter.TypeMessage($"Welcome aboard, {UserName}! Ask me anything about staying safe online.", ConsoleColor.White);
                    UIFormatter.TypeMessage("(Type 'help' to see recommended topics, or 'exit' to quit at any time.)", ConsoleColor.DarkCyan);
                    UIFormatter.PrintDivider();
                    break;
                }

                UIFormatter.DisplayError("Name cannot be blank. Please enter a valid name.");
            }
        }

        public bool ProcessInput(string? rawInput)
        {
            if (string.IsNullOrWhiteSpace(rawInput))
            {
                UIFormatter.DisplaySpeaker("Assistant", ConsoleColor.Cyan);
                UIFormatter.TypeMessage($"It looks like you didn't type anything, {UserName}. Please ask me a question!", ConsoleColor.DarkYellow);
                return true;
            }

            string input = rawInput.Trim().ToLower();

            if (input == "exit" || input == "quit" || input == "bye")
            {
                UIFormatter.DisplaySpeaker("Assistant", ConsoleColor.Cyan);
                UIFormatter.TypeMessage($"Stay safe out there, {UserName}! Have a great day.", ConsoleColor.Green);
                return false;
            }

            UIFormatter.DisplaySpeaker("Assistant", ConsoleColor.Cyan);

            if (input.Contains("how are you"))
            {
                UIFormatter.TypeMessage($"I'm functioning perfectly, {UserName}! Ready to help secure your digital footprint.", ConsoleColor.White);
            }
            else if (input.Contains("purpose") || input.Contains("what do you do") || input.Contains("who are you"))
            {
                UIFormatter.TypeMessage("I am a Cybersecurity Awareness Assistant designed to educate users on identifying online threats like phishing and scams.", ConsoleColor.White);
            }
            else if (input.Contains("help") || input.Contains("what can i ask") || input.Contains("topics"))
            {
                UIFormatter.TypeMessage($"Here are key topics we can discuss, {UserName}:", ConsoleColor.White);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("  📌 Phishing     ➜ Scam emails, fake SMS & suspicious links");
                Console.WriteLine("  📌 Passwords    ➜ Creating strong passphrases & Multi-Factor Auth (MFA)");
                Console.WriteLine("  📌 Safe Browsing ➜ Identifying secure websites & avoiding web traps");
                Console.ResetColor();
            }
            else if (input.Contains("phishing") || input.Contains("scam"))
            {
                UIFormatter.TypeMessage("Phishing attempts trick you into revealing personal info. Always verify sender email addresses, watch out for urgent financial warnings, and NEVER click unknown links!", ConsoleColor.White);
            }
            else if (input.Contains("password") || input.Contains("passwords"))
            {
                UIFormatter.TypeMessage("Strong password guidelines: Use 12+ characters combining uppercase, lowercase, numbers, and symbols. Never reuse passwords across sites and enable MFA!", ConsoleColor.White);
            }
            else if (input.Contains("browse") || input.Contains("browsing") || input.Contains("link") || input.Contains("website"))
            {
                UIFormatter.TypeMessage("Safe Browsing Tip: Check that website URLs start with 'https://' and display a padlock icon. Avoid downloading unknown attachments or clicking pop-up ads.", ConsoleColor.White);
            }
            else
            {
                UIFormatter.TypeMessage($"I didn't quite understand that, {UserName}. Try asking about 'phishing', 'passwords', or 'safe browsing'.", ConsoleColor.DarkYellow);
            }

            UIFormatter.PrintDivider();
            return true;
        }
    }
}