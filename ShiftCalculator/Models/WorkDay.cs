using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftCalculator.Models
{
    public class WorkDay
    {
        public WorkDay(HourMin start, HourMin end)
        {
            Start = start;
            End = end;
        }

        public HourMin Start { get; set; }
        public HourMin End { get; set; }
        public int HoursTotal { get; set; }
    }
}
