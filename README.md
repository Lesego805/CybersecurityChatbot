# 🛡️ Cybersecurity Awareness Assistant

An interactive C# console application designed to educate users on essential cybersecurity topics, including phishing awareness, password best practices, and safe browsing habits. Built using .NET 8.0 in Microsoft Visual Studio.

---

## 📌 Project Overview
The **Cybersecurity Awareness Assistant** delivers a personalized and engaging user interface complete with audio greetings, ASCII art headers, and interactive topic modules. It serves as an educational tool to help users recognize online security threats and adopt safe digital practices.

---

## 📸 Application Screenshots

### Main Interface & ASCII Banner
![Main Interface & ASCII Banner]("C:\Users\Lsego\Pictures\Screenshots\Screenshot 2026-09-09 214644.png")
*Figure 1: Main Menu with custom ASCII header and user greeting.*

### Phishing Quiz & Educational Module
![Phishing Module](screenshots/phishing-module.png)
*Figure 2: Interactive cybersecurity learning module with input validation.*

---

## 🚀 Key Features
* **🎙️ Audio Greeting:** Plays an introductory `.wav` audio greeting upon application launch (`AudioPlayer.cs`).
* **🎨 Custom Terminal UI:** Custom-styled terminal card layouts and ASCII banners (`UIFormatter.cs`).
* **👤 User Personalization:** Captures user name and tracks interaction history.
* **📚 Educational Modules:** Detailed guidance and interactive quizzes on:
  * Phishing Prevention & Email Safety
  * Strong Password Management
  * Safe Web Browsing & Online Safety
* **🛡️ Robust Input Validation:** Prevents crashes and handles invalid user selections seamlessly.

---

## 🛠️ Technology Stack
* **Language:** C# (.NET 8.0)
* **IDE:** Microsoft Visual Studio 2022
* **Audio Engine:** `System.Media.SoundPlayer`
* **Version Control:** Git & GitHub
* **CI/CD Pipeline:** GitHub Actions

---

## ⚙️ Installation & Running Locally

1. **Clone the Repository:**
   ```bash
   git clone [https://github.com/YOUR_GITHUB_USERNAME/Cybersecurity-Awareness-Assistant.git](https://github.com/YOUR_GITHUB_USERNAME/Cybersecurity-Awareness-Assistant.git)
   cd Cybersecurity-Awareness-Assistant
