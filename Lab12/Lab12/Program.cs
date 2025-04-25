using System;
using System.Threading;

namespace TimeAlarmConsole
{
    // Define the delegate
    public delegate void AlarmEventHandler();

    class Alarm
    {
        // Declare the event
        public event AlarmEventHandler RaiseAlarm;

        public void Start(DateTime targetTime)
        {
            while (true)
            {
                DateTime currentTime = DateTime.Now;
                Console.WriteLine("Current Time: " + currentTime.ToLongTimeString());

                if (currentTime.Hour == targetTime.Hour &&
                    currentTime.Minute == targetTime.Minute &&
                    currentTime.Second == targetTime.Second)
                {
                    RaiseAlarm?.Invoke(); // Raise the event
                    break;
                }

                Thread.Sleep(1000); // wait 1 second
            }
        }
    }

    class Program
    {
        static void Ring_alarm()
        {
            Console.WriteLine("Alarm! Time's up!");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter target time (HH:MM:SS): ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime targetTime))
            {
                Alarm alarm = new Alarm();
                alarm.RaiseAlarm += new AlarmEventHandler(Ring_alarm); // subscribe to event
                alarm.Start(targetTime);
            }
            else
            {
                Console.WriteLine("Invalid time format.");
            }
        }
    }
}
