namespace CarLibrary
{
    public enum EngineState
    {
        EngineAlive,
        EngineDead
    }

    public abstract class Car
    {
        public string CarName { get; set; }
        public int CarSpeed { get; set; }
        public int MaxSpeed { get; set; }

        protected EngineState EState = EngineState.EngineAlive;
        public EngineState EngineState => EState;

        public abstract void TurboBoost();

        protected Car()
        {
            
        }

        protected Car(string carName, int carSpeed, int maxSpeed)
        {
            CarName = carName;
            CarSpeed = carSpeed;
            MaxSpeed = maxSpeed;
        }
    }
}
