using System;
using System.Collections.Generic;

namespace Helper
{
    class Lists
    {
        public int GetCurrentYear()
        {
            int year = DateTime.Now.Year;
            return year;
        }   public int GetCurrentMonth()
        {
            int month = DateTime.Now.Month;
            return month;
        }   public int GetCurrentDay()
        {
            int day = DateTime.Now.Day;
            return day;

        }
       
        public List<string> Status = new List<string>
        {
            "Занятие",
            "Звонок",
            "Перемена"
        };


        public List<DateTime> TimeOfStart = new List<DateTime> { };
        public List<DateTime> TimeOfHalf = new List<DateTime> { };
        public List<DateTime> TimeOfEnd = new List<DateTime> { };
        public List<DateTime> TimeOfHalfEnd = new List<DateTime> { };
    }
}
