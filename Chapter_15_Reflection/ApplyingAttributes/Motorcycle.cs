using System;

namespace ApplyingAttributes
{
    [Serializable]
    public class Motorcycle
    {
        [NonSerialized]
        public float WeightPassenger;

        public bool HasRadioSystem;
        public bool HasHeadSet;
        public bool HasBar;
    }
}
