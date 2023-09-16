using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeOOP.Clases
{
     public abstract class Employee
    {
        #region Properties
        public int Id { get; set; }
        public int? FirstName { get; set; }

        public int? LastName { get; set; }

        public Date? BirthDate { get; set; }

        public Date? HiringDate { get; set; }

        public bool? IsActive { get; set; }
        #endregion Properties

        #region Methods

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"INFORMACIÓN DEL EMPLEADO \n\t " +
                   $"ID: {Id}\n\t" +
                   $"Nombres: {FirstName}\n\t" +
                   $"Apellidos: {LastName}\n\t" +
                   $"Fecha de cumpleaños: {BirthDate}\n\t" +
                   $"Fecha de contratación: {HiringDate}\n\t" +
                   $"¿Empleado activo?: {IsActive}\n\t"; 
        }

        #endregion Methods
    }
}
