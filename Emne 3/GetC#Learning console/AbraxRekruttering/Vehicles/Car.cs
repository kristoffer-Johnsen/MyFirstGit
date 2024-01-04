

using System.Drawing;
using AbaxRekruttering.Vehicles.Interfaces;

namespace AbaxRekruttering.Vehicles
{
    internal class Car : Vehicle, ITopSpeed, IColored
    {
        public Color Color { get; set; }
        public int TopSpeed { get; set; }

        public Car(string registration, int effect, int speed, Color color) : base(registration, effect)
        {
            Color = color;
            TopSpeed = speed;
        }

        
    }
}