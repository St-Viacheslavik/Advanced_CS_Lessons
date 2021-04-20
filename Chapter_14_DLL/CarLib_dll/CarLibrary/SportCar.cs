using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace CarLibrary
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class SportCar : Car
    {
        public SportCar() { }

        public SportCar(string carName, int carSpeed, int maxSpeed) : base(carName, carSpeed, maxSpeed) { }

        public override void TurboBoost()
        {
            MessageBox.Show("Максимум скорости", "Чем быстрее тем лучше :-)");
        }
    }
}
