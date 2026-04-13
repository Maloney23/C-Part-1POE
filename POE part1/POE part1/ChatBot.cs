using System;

class ChatBot
{
    private string userName;

    public ChatBot(string name)
    {
        userName = name;
    }

    public void StartChat()
    {
        UIHelper.TypeText($"\nHello {userName}! I'm your Cybersecurity Assistant.");
        UIHelper.TypeText("Ask me anything about staying safe online.\n");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("> ");
            Console.ResetColor();

            string input = Console.ReadLine().ToLower();

            // Input validation
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("⚠️ Please enter something.");
                continue;
            }

            Respond(input);
        }
    }

    private void Respond(string input)
    {
        if (input.Contains("how are you"))
        {
            UIHelper.TypeText("I'm just a bot, but I'm functioning perfectly!");
        }
        else if (input.Contains("purpose"))
        {
            UIHelper.TypeText("My purpose is to help you stay safe online.");
        }
        else if (input.Contains("password"))
        {
            UIHelper.TypeText("Use strong passwords with at least 12 characters, including symbols and numbers.");
        }
        else if (input.Contains("phishing"))
        {
            UIHelper.TypeText("⚠️ Phishing is when attackers trick you into revealing personal information through fake emails or websites.");
        }
        else if (input.Contains("safe browsing") || input.Contains("browsing"))
        {
            UIHelper.TypeText("Always check URLs and avoid clicking suspicious links.");
        }
        else if (input.Contains("scam"))
        {
            UIHelper.TypeText("Be careful of deals that seem too good to be true.");
        }
        else if (input.Contains("exit"))
        {
            UIHelper.TypeText("Goodbye! Stay safe online 🔐");
            Environment.Exit(0);
        }
        else
        {
            UIHelper.TypeText("I didn’t quite understand that. Could you rephrase?");
        }
    }
}