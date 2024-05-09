using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Assignment_2024
{
    // Concrete Strategy: Towing capabilities
    class TowingCapability : ICapability
    {
        private string _towingType;

        public TowingCapability(string towingType)
        {
            _towingType = towingType;
        }

        public string GetCapabilities()
        {
            return $"Towing capabilities: {_towingType}";
        }
    }
}
