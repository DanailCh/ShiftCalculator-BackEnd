using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftCalculator
{
    public class HourMin
    {
        private int hour;
        private int minute;

        public HourMin(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }

        public int Hour
        {
            get
            {
                return this.hour;
            }

            private set
            {
                if (value<0||value>23)
                {
                    throw new Exception("Invalid hour range.");
                }
                this.hour = value;
            }
        }
        public int Minute
        {
            get
            {
                return this.minute;
            }

            private set
            {
                if (value < 0 || value > 59)
                {
                    throw new Exception("Invalid minute range.");
                }
                this.minute = value;
            }
        }
        public override string ToString()
        {
            return hour+":"+minute;
        }
    }
}
