using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DP_Assignment_2024
{
    // Concrete Strategy: Carrier capabilities
    public class CarrierCapability : ICapability
    {
        private string _carrierType;

        public CarrierCapability(string carrierType)
        {
            _carrierType = carrierType;
        }

        public string GetCapabilities()
        {
            return $"Carrier capabilities: {_carrierType}";
        }
    }
}
