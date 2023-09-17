using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeOOP.Clases
{
    public class BaseComissionEmployee : ComissionEmployee 
    {
        #region Properties
        public decimal Base { get; set; }
        #endregion Properties

        #region Methods

        public override decimal GetValueToPay()
        {
            decimal comission;
            ComissionPercenteje = 23000000;
            comission = Sales * ComissionPercenteje / 100;
            Base = Base * comission;
            return Base;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"El pago es: {Base:C2}\n\t";
        }

        #endregion Methods




    }
}
