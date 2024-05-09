using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Assignment_2024
{
    // Decorator Pattern: Concrete decorator (optional feature)
    class Camera : OptionalFeature
    {
        public Camera(Vehicle vehicle) : base(vehicle) { }

        public override string GetDescription()
        {
            return "Camera";
        }

        public override decimal GetCost()
        {
            return 200; // Base price for adding a camera
        }
    }
}
