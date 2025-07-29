using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB.OOP
{
    class time
    {
        double hour;
        double minute;
        double second;
        public void getData(double hour,double minute, double second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public void showData()
        {
            Console.Write(hour +":");
            Console.Write(minute + ":");
            Console.Write(second + ":");
        }

    }
    internal class Time
    {
        public static void Main(string[] args)
        {
            time t=new time();
            t.getData(11,28,35);
            t.showData();
        }
    }
}
