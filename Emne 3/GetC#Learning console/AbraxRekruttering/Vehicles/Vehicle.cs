
using AbaxRekruttering.Vehicles.Interfaces;

namespace AbaxRekruttering.Vehicles
{
    class Vehicle : IVehicle
    {
        public string _registration { get; set; }
        public int _effect { get; set; }

        public Vehicle(string registration, int effect)
        {
            _registration = registration;
            _effect = effect;
        }
    }
}
