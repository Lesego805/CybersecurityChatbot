using System;
using System.IO;
using System.Media;

namespace CybersecurityChatbot
{
    /// <summary>
    /// Handles audio playback for the chatbot voice greeting.
    /// </summary>
    public static class AudioPlayer
    {
        public static void PlayGreeting(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using SoundPlayer player = new SoundPlayer(filePath);
                    player.Play(); // Plays audio asynchronously
                }
                else
                {
                    UIFormatter.DisplayWarning($"[Audio Notice]: Voice greeting file not found at '{filePath}'. Continuing with text experience.");
                }
            }
            catch (PlatformNotSupportedException)
            {
                UIFormatter.DisplayWarning("[Audio Notice]: Sound playback is only supported on Windows operating systems.");
            }
            catch (Exception ex)
            {
                UIFormatter.DisplayWarning($"[Audio Notice]: Could not play greeting audio. ({ex.Message})");
            }
        }
    }
}