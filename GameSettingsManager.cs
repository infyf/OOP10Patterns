

namespace OOP
{
    public class GameSettingsManager : IGameSettings
    {
        private static GameSettingsManager instance;

        private int volume;
        private string difficulty;
        private bool soundEnabled;


        private GameSettingsManager()
        {
            volume = 50;
            difficulty = "Normal";
            soundEnabled = true;
        }

    
        public static GameSettingsManager GetInstance()
        {
            if (instance == null)
            {
                instance = new GameSettingsManager();
            }
            return instance;
        }

        
        public int GetVolume() => volume;

        public void SetVolume(int value)
        {
            if (value >= 0 && value <= 100)
                volume = value;
        }

        public string GetDifficulty() => difficulty;

        public void SetDifficulty(string difficulty)
        {
            this.difficulty = difficulty;
        }

        public bool IsSoundEnabled() => soundEnabled;

        public void ToggleSound()
        {
            soundEnabled = !soundEnabled;
        }
    }
}