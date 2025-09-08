using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rushi_Sorathiya_23SOECE11037
{
    class Clock
    {
        // Private data members
        private int hour;
        private int min;
        private int sec;

        // No-argument constructor (default time 12:00:00)
        public Clock()
        {
            hour = 12;
            min = 0;
            sec = 0;
        }

        // Three-argument constructor (initialize with given time)
        public Clock(int h, int m, int s)
        {
            hour = h;
            min = m;
            sec = s;
        }

        // Method to increment time by 1 second
        public void Increment()
        {
            sec++; // increase second

            if (sec == 60)  // rollover to next minute
            {
                sec = 0;
                min++;
            }

            if (min == 60)  // rollover to next hour
            {
                min = 0;
                hour++;
            }

            if (hour == 24)  // reset after 23:59:59
            {
                hour = 0;
            }
        }

        // Method to display time
        public void DisplayTime()
        {
            Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}");
        }

        // Getter methods
        public int getHour()
        {
            return hour;
        }

        public int getMinute()
        {
            return min;
        }

        public int getSeconds()
        {
            return sec;
        }
    }
    internal class Q2
    {
        static void Main(string[] args)
        {
            // Using default constructor
            Clock c1 = new Clock();
            Console.WriteLine("Clock 1 (Default):");
            c1.DisplayTime();

            // Increment few seconds
            c1.Increment();
            c1.Increment();
            Console.WriteLine("After 2 seconds increment:");
            c1.DisplayTime();

            // Using parameterized constructor
            Clock c2 = new Clock(23, 59, 58);
            Console.WriteLine("\nClock 2 (Parameterized):");
            c2.DisplayTime();

            // Increment to test rollover
            c2.Increment(); // 23:59:59
            c2.DisplayTime();
            c2.Increment(); // 00:00:00 (rollover)
            c2.DisplayTime();

            Console.ReadLine();
        }
    }
}
