using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeOOP.Clases
{
    public class Date
    {
        #region Fields

        private int _year;
        private int _month;
        private int _day;

        #endregion

        #region Methods

        public Date(int day, int month, int year)
        {
            _year = ValidateYear(year);
            _month = ValidateMonth(month);
            _day = ValidateDay(day, month, year);
        }

        private int ValidateDay(int day, int month, int year)
        {
            // Validar si el día ingresado pertenence a un año bisiesto
            if(month==2 && day==29 && IsleapYear(year))
            {
                return day;
            }


            if (month == 2 && day == 29 && IsleapYear(year))
            {
                bool isLeapYear = false;
                IsLeapYearException(isLeapYear, year);
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if(day>=1 && day <= daysPerMonth[month])
            {
                return day;
            }
            else
            {
                throw new DayException(String.Format("El día {0} no es válido para el mes {1}", day , month));
            }
        }

        private void IsLeapYearException(bool isLeapYear, int year)
        {
            if (!isLeapYear) {
                throw new YearException(String.Format("El año {0} no es bisisesto", year));
            }
        }

        private bool IsleapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            else
            {
                //Exception creation
                throw new YearException(String.Format("El año {0} no exíste", year));
            }
        }

        private int ValidateMonth(int month)
        {
            if(month>=1 && month <= 12)
            {
                return month;
            }
            else
            {
                //Exception creation
                throw new MonthException(String.Format("El mes {0} no exíste" , month));
            }
        }

        public override string ToString()
        {
            var dateConcatenated = _day + "/" + _month + "/" + _year;
            return dateConcatenated;


        }


        #endregion




    }
}
