using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Assignment_2024
{
    // Decorator Pattern: Concrete decorator (optional feature)
    class WiFi : OptionalFeature
    {
        public WiFi(Vehicle vehicle) : base(vehicle) { }

        public override string GetDescription()
        {
            return "WiFi";
        }

        public override decimal GetCost()
        {
            return 750; // Base price for adding WiFi
        }
    }
}
