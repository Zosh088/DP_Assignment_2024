using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Assignment_2024
{
    // Decorator Pattern: Concrete decorator (optional feature)
    class SoundSystem : OptionalFeature
    {
        public SoundSystem(Vehicle vehicle) : base(vehicle) { }

        public override string GetDescription()
        {
            return "Sound System";
        }

        public override decimal GetCost()
        {
            return 1000; // Base price for adding a sound system
        }
    }
}
