using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeOOP.Clases
{
    public class ComissionEmployee : Employee
    {
        #region Properties
        public int ComissionPercenteje { get; set; }
        public int Sales { get; set;}
        #endregion Properties

        #region Methods

        
        public override decimal GetValueToPay()
        {
            return Sales;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"El total de ventas fue de {Sales:C2}\n\t";
        }

         

        #endregion Methods
    }
}
