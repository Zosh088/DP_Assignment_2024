using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Assignment_2024
{
    // Decorator Pattern: Component (optional feature)
    abstract class OptionalFeature
    {
        protected Vehicle _vehicle;

        public OptionalFeature(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public abstract string GetDescription();

        public abstract decimal GetCost();
    }
}
