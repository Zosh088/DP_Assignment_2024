using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Assignment_2024
{
    // Observer Pattern: Concrete observer (technician)
    class Technician : IObserver
    {
        public string Name { get; }
        private decimal _hourlyRate;

        public Technician(string name, decimal hourlyRate)
        {
            Name = name;
            _hourlyRate = hourlyRate;
        }

        public void Update(Vehicle vehicle)
        {
            Console.WriteLine($"Technician {Name} notified of vehicle update: {vehicle.Description}");
            // Perform tasks based on the vehicle update
        }

        public decimal GetHourlyRate(string feature)
        {
            switch (feature)
            {
                case "Sound System":
                    return _hourlyRate * 10;
                case "WiFi":
                    return _hourlyRate * 7.5M;
                case "Camera":
                    return _hourlyRate * 2;
                default:
                    return 0;
            }
        }
    }
}
