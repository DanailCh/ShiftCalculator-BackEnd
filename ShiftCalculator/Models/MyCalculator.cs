using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShiftCalculator.Models;

namespace ShiftCalculator
{
    //TO DO: think of better names
    public  class MyCalculator
    {
        
        public int[] CalculateMonthHours(List<WorkDay> workDays)
        {
            List<HourMin> hourMinList = new List<HourMin>();
            foreach (var workday in workDays)
            {
                hourMinList.Add(CalculateDayHours(workday));
            }
            int allMinutes=hourMinList.Sum(x=>x.Minute);
            int allHours=hourMinList.Sum(x=>x.Hour);
            int hoursToAdd = allMinutes / 60;
            if (allMinutes%60!=0)
            {
                allMinutes -= (hoursToAdd * 60);
            }
            else
            {
                allMinutes = 0;
            }
            allHours+=hoursToAdd;
            int[] result = new int[2] { allHours,allMinutes };
            
            return result;
        }
        public HourMin CalculateDayHours(WorkDay currDay)
        {
            int startHour=currDay.Start.Hour;
            int endHour=currDay.End.Hour;
            int startMinute=currDay.Start.Minute;
            int endMinute=currDay.End.Minute;

            int totalHours=endHour-startHour;
            if (totalHours<0)//For night shifts
            {
                totalHours += 24;
            }
            int totalMinutes=endMinute-startMinute;
            if (totalMinutes<0)
            {
                totalHours--;
                totalMinutes=60-Math.Abs(totalMinutes);
            }
            if (totalMinutes>59)//Could happen Dont know how to break it yet
            {
                Console.WriteLine("Something went wrong.totalMinutes: " + totalMinutes);
            }
            HourMin result=new HourMin(totalHours,totalMinutes);
            return result;
        }
    }
}
