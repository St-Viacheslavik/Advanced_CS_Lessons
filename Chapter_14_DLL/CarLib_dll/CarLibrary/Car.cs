using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace CarLibrary
{
    public enum EngineState
    {
        EngineAlive,
        EngineDead
    }

    public enum MusicMedia
    {
        MusicCd,
        MusicTape,
        MusicRadio,
        MusicMp3
    }

    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public abstract class Car
    {
        public string CarName { get; set; }
        public int CarSpeed { get; set; }
        public int MaxSpeed { get; set; }

        protected EngineState EState = EngineState.EngineAlive;
        public EngineState EngineState => EState;

        public void TurnOnRadio(bool musicOn, MusicMedia music) => MessageBox.Show(musicOn ? $"Выбран формат: {music}" : "Радио выключено", "Информация");

        public abstract void TurboBoost();

        protected Car()
        {
            MessageBox.Show("Вы используете версию 2.0.0.0!!!", "Вышло обновление");
        }

        protected Car(string carName, int carSpeed, int maxSpeed)
        {
            CarName = carName;
            CarSpeed = carSpeed;
            MaxSpeed = maxSpeed;
            MessageBox.Show("Вы используете версию 2.0.0.0!!!", "Вышло обновление");
        }
    }
}
