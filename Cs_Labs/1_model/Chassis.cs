using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_model
{
    public class Chassis
    {
        public bool IsDown { get; set; }
        public double WheelDiameter { get; set; }

        public Chassis()
        {
            IsDown = true;
            WheelDiameter = 0.0;
        }

        public Chassis(double wheelDiameter)
        {
            IsDown = true;
            WheelDiameter = wheelDiameter;
        }
    }
}
