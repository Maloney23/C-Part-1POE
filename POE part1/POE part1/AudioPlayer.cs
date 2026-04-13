﻿using System;
using System.Media;


public class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.PlaySync();
            player.Load();
            player.PlaySync();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
