using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_model
{
    public class Engine
    {
        public bool IsConditionOfFlight { get; set; }
        public double Power { get; set; }

        public Engine()
        {
            IsConditionOfFlight = false;
            Power = 0.0;
        }

        public Engine(double power)
        {
            IsConditionOfFlight = false;
            Power = power;
        }
    }
}
