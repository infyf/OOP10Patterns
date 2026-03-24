using OOP;
using System;

class Program
{
    static void Main()
    {
        IGameSettings settings1 = GameSettingsManager.GetInstance();
        IGameSettings settings2 = GameSettingsManager.GetInstance();

        settings1.SetVolume(80);
        settings1.SetDifficulty("Hard");
        settings1.ToggleSound();

        Console.WriteLine("Volume: " + settings2.GetVolume());
        Console.WriteLine("Difficulty: " + settings2.GetDifficulty());
        Console.WriteLine("Sound Enabled: " + settings2.IsSoundEnabled());

        Console.WriteLine("Same instance? " + (settings1 == settings2));
    }
}
