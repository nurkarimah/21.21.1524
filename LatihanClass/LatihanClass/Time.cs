using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
    internal class Time
    {
        // private variables atau field
        public int year;
        private int month;
        private int date;
        private int hour;
        private int minute;
        private int second;

        public Time()
        {
            year = 2018;
            month = 10;
            date = 10;
            hour = 10;
            minute = 30;
            second = 40;
        }

        // overload constructor
        public Time(int year, int month, int date,
         int hour, int minute, int second)
        {
            this.year = year;
            this.month = month;
            this.date = date;
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

            // public methods
            public void DisplayCurrentTime()
        {
            Console.WriteLine("Waktu sekarang : {0}", DateTime.Now.ToString());
        }

        // property
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Date
        {
            get { return date; }
            set { date = value; }
        }
        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }
        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }
        public int Second
        {
            get { return second; }
            set { second = value; }
        }



    }
}
