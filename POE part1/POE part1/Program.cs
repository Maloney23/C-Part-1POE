using System;

class Program
{
    static void Main()
    {
        AudioPlayer.PlayGreeting();

        UIHelper.DisplayLogo();

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        ChatBot bot = new ChatBot(name);
        bot.StartChat();
    }
}