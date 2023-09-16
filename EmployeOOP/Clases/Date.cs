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
            _year = year;
            _month = month;
            _day = day;
        }

        public override string ToString()
        {
            var dateConcatenated = _day + "/" + _month + "/" + _year;
            return dateConcatenated;


        }


        #endregion




    }
}
