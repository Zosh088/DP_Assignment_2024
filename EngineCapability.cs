using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Assignment_2024
{
    // Concrete Strategy: Engine type
    class EngineCapability : ICapability
    {
        private string _engineType;

        public EngineCapability(string engineType)
        {
            _engineType = engineType;
        }

        public string GetCapabilities()
        {
            return $"Engine type: {_engineType}";
        }
    }
}
