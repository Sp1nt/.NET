using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4._1
{
    internal class MyDatesList
    {
        private int _day = 0;
        private int _month = 0;
        private int _year = 0;

        public MyDatesList() 
        {
            _day = 15;
            _month = 10;
            _year = 2005;
        }
        public MyDatesList(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

        public int Day 
        { 
            get => _day;
            set => _day = value;
        }

        public int Month 
        {
            get => _month;
            set => _month = value;
        }
        public int Year 
        {
            get => _year;
            set => _year = value;
        }

        public string Day_Of_Week
        {
            get
            {
                DateTime date = new DateTime(_year, _month, _day);
                return date.DayOfWeek.ToString();
            }
        }

        public string PrintDate() 
        { 
            return Day.ToString() + "." + Month.ToString() + "." + Year.ToString(); 
        }

        public int DaysDiff(MyDatesList a)
        {
            DateTime fDate = new DateTime(_year, _month, _day);
            DateTime lDate = new DateTime(a.Year, a.Month, a.Day);

            if (fDate < lDate) 
            {
                return (lDate - fDate).Days;
            }
            else
            {
                return (fDate - lDate).Days;
            }

            
        }

        public void AddDaysToDate(int a)
        {
            DateTime date = new DateTime(_year, _month, _day).AddDays(a);
            _day = date.Day;
            _month = date.Month;
            _year = date.Year;
        }
    }
}
