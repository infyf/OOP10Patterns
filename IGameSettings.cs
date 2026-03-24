

namespace OOP
{
    public interface IGameSettings
    {
        int GetVolume();
        void SetVolume(int value);

        string GetDifficulty();
        void SetDifficulty(string difficulty);

        bool IsSoundEnabled();
        void ToggleSound();
    }
}