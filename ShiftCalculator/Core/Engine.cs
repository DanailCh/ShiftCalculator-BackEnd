using ShiftCalculator.Models;

namespace ShiftCalculator.Core
{

    public class Engine
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start:");
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            HourMin hm = new HourMin(hour, minute);
            Console.WriteLine(hm);
            Console.WriteLine("end:");
            hour = int.Parse(Console.ReadLine());
            minute = int.Parse(Console.ReadLine());
            HourMin hm2 = new HourMin(hour, minute);
            Console.WriteLine(hm2);
            MyCalculator calc = new MyCalculator();
            WorkDay workDay = new WorkDay(hm, hm2);
            Console.WriteLine("end result " + calc.CalculateDayHours(workDay));
        }
    }

}
