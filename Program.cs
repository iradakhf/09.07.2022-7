using System;
namespace ConsoleApp15
{
    class Program
    {
        public static void Main (string[] args)
        {
            //Task is to write a function which returns the time since midnight in milliseconds.
            var timeInMilliSeconds= ReturnTimeSinceMidnightInMilliSeconds(0, 1, 1);
            Console.WriteLine(timeInMilliSeconds);
        }
        public static uint ReturnTimeSinceMidnightInMilliSeconds(uint hour, uint minutes, uint seconds)
        {
            uint hourInMilliSeconds = 0;
            uint minutesInMilliSeconds = 0;
            uint secondsInMilliSeconds = 0;
            if ((hour < 24 && minutes < 60 && seconds < 60)&& (hour>=0 && minutes>=0 && seconds>=0))
            {  secondsInMilliSeconds = seconds*1000;
                minutesInMilliSeconds = secondsInMilliSeconds + minutes*60 * 1000;
                hourInMilliSeconds = minutesInMilliSeconds + hour * 360 * 1000;
            }
            return hourInMilliSeconds;
        } 
    }

}