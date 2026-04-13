using System;
using System.Threading;

class UIHelper
{
    public static void DisplayLogo()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine(@"
   _____       _               _____                 _       
  / ____|     | |             / ____|               | |      
 | |     _   _| |__   ___ _ _| (___  _   _ _ __ ___ | |__    
 | |    | | | | '_ \ / _ \ '__\___ \| | | | '_ ` _ \| '_ \   
 | |____| |_| | |_) |  __/ |  ____) | |_| | | | | | | |_) |  
  \_____|\__, |_.__/ \___|_| |_____/ \__, |_| |_| |_|_.__/   
          __/ |                       __/ |                  
         |___/                       |___/                   

        🔐 CYBERSECURITY AWARENESS BOT 🔐
");

        Console.ResetColor();
        Console.WriteLine("==============================================\n");
    }

    public static void TypeText(string text)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }
        Console.WriteLine();
    }
}