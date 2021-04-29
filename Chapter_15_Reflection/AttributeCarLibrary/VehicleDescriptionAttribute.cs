using System;

namespace AttributeCarLibrary
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, AllowMultiple = true, Inherited = false)]
    public sealed class VehicleDescriptionAttribute : Attribute
    {
        public string Description { get; set; }

        public VehicleDescriptionAttribute() { }

        public VehicleDescriptionAttribute(string description) => Description = description;
    }
}
