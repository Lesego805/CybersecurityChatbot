# 🛡️ Cybersecurity Awareness Assistant (Chatbot)

An interactive, C#-based console application designed to educate users on essential cybersecurity concepts, online safety practices, and threat mitigation strategies. Built with .NET 8.0, this tool features a clean ASCII interface, smooth text-typing animations, audio greeting capabilities, and robust input validation.

---

## 📌 Project Overview

The **Cybersecurity Awareness Assistant** helps users navigate common digital safety challenges by providing instant, reliable information on core topics:
* **Phishing & Scam Identification**: Recognizing suspicious links, deceptive emails, and social engineering tactics.
* **Password Management**: Guidance on constructing strong passphrases, avoiding password reuse, and implementing Multi-Factor Authentication (MFA).
* **Safe Browsing Practices**: Verifying SSL/TLS website certificates (`https://`), avoiding malicious attachments, and dodging web pop-ups.

---

## 🚀 Features

* **Interactive Natural Chat Engine**: Uses keyword parsing and custom string matching to address user inquiries dynamically.
* **ASCII Console UI (`UIFormatter.cs`)**: Styled headers, themed speaker indicators, custom color coding, and character-by-character typing animations.
* **Integrated Audio Player (`AudioPlayer.cs`)**: Utilizes `System.Media.SoundPlayer` to render an audio greeting upon application startup.
* **Input Validation & Error Handling**: Gracefully handles blank inputs, invalid commands, and unexpected user entries without crashing.
* **UTF-8 Compatibility**: Configured to handle standard text rendering cleanly across command terminals.

---

## 🛠️ System Architecture

The application follows a modular, single-responsibility C# class structure:

| File | Purpose |
| :--- | :--- |
| `Program.cs` | Main application entry point; initializes console configurations, audio execution, and the main loop. |
| `ChatEngine.cs` | Core logic handling session initialization, user input parsing, topic processing, and exit signals. |
| `UIFormatter.cs` | Visual presentation layer responsible for printing ASCII banners, typing animations, and colored badges. |
| `AudioPlayer.cs` | Sound utility handling `System.Media.SoundPlayer` file checks, path validation, and audio execution. |

---

## 📋 Prerequisites & Requirements

* **Operating System**: Windows 10 / 11 (required for native `System.Media.SoundPlayer` audio execution).
* **SDK / Framework**: [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or higher.
* **IDE**: Microsoft Visual Studio 2022 (with *.NET desktop development* workload installed) or Visual Studio Code.
* **Dependencies**: `System.Windows.Extensions` package for sound playback support.

---

## 📦 Installation & Setup

1. **Clone the Repository**:
   ```bash
   git clone [https://github.com/Lesego805/CybersecurityChatbot.git](https://github.com/Lesego805/CybersecurityChatbot.git)
   cd CybersecurityChatbot
