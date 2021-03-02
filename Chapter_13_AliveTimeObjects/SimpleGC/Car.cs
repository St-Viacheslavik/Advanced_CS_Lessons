using System.Diagnostics.CodeAnalysis;

namespace SimpleGC
{
    public class Car
    {
        public string CarName { get; set; }
        public int CarSpeed { get; set; }

        public Car() : this("NaN", 0) { }
        public Car(string carName, int carSpeed)
        {
            CarName = carName;
            CarSpeed = carSpeed;
        }

        [SuppressMessage("ReSharper", "CommentTypo")]
        private static void MakeCar()
        {
            /*
             * Этот метод нужен только для того чтобы посмотреть CIL код
             */
            var car = new Car();
            car = null;
        }

        public override string ToString() => $"Car name: {CarName}, car speed: {CarSpeed}";
    }
}
