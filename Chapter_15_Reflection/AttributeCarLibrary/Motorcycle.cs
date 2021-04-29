using System;

namespace AttributeCarLibrary
{
    [Serializable]
    [VehicleDescription ("Мой харлей")]
    public class Motorcycle
    {
        [NonSerialized]
        public float WeightPassenger;

        public bool HasRadioSystem;
        public bool HasHeadSet;
        public bool HasBar;
    }
}
