using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_model
{
    public class Wing
    {
        public bool IsConditionOfFlight { get; set; }
        public double Length { get; set; }

        public Wing()
        {
            IsConditionOfFlight = false;
            Length = 0.0;
        }

        public Wing(double length)
        {
            IsConditionOfFlight = false;
            Length = length;
        }
    }
}
