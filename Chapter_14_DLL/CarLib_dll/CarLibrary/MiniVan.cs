using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace CarLibrary
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class MiniVan : Car
    {
        public MiniVan() { }

        public MiniVan(string carName, int carSpeed, int maxSpeed) : base(carName, carSpeed, maxSpeed) { }

        public override void TurboBoost()
        {
            EState = EngineState.EngineDead;
            MessageBox.Show("Двигатель всё", "Надо было брать спорткар");
        }

    }
}
