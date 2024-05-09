using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Assignment_2024
{
    // Context class (vehicle)
    class Vehicle
    {
        private List<IObserver> _observers = new List<IObserver>();
        private List<OptionalFeature> _optionalFeatures = new List<OptionalFeature>();
        private ICapability _capability;
        private string _vehicleType;

        public string Description { get; private set; }

        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        public void AttachObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void SetCapability(ICapability capability)
        {
            _capability = capability;
            NotifyObservers();
        }

        public void AddOptionalFeature(OptionalFeature optionalFeature)
        {
            _optionalFeatures.Add(optionalFeature);
            UpdateDescription();
        }

        public decimal CalculateTotalCost()
        {
            decimal totalCost = 0;
            foreach (var feature in _optionalFeatures)
            {
                totalCost += feature.GetCost() + GetTechnicianRate(feature.GetDescription());
            }
            return totalCost;
        }

        private decimal GetTechnicianRate(string feature)
        {
            foreach (var observer in _observers)
            {
                if (observer is Technician technician && technician.Name.Contains(_vehicleType))
                {
                    return technician.GetHourlyRate(feature);
                }
            }
            return 0;
        }

        private void UpdateDescription()
        {
            Description = _capability.GetCapabilities();
            foreach (var feature in _optionalFeatures)
            {
                Description += $", {feature.GetDescription()}";
            }
        }

        private void NotifyObservers()
        {
            // Notify only one random observer
            Random random = new Random();
            var observerIndex = random.Next(_observers.Count);
            _observers[observerIndex].Update(this);
        }

        public string GetDescription()
        {
            return Description;
        }
    }
}
